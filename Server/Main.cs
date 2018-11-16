using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Main : Form
    {
        private readonly Listener listener;

        public List<Socket> clients = new List<Socket>(); // store all the clients into a list

        public void BroadcastData(string data) // send to all clients
        {
            foreach (var socket in clients)
            {
                try { socket.Send(Encoding.ASCII.GetBytes(data)); }
                catch (Exception) { }
            }
        }

        public Main()
        {
            pChat = new PrivateChat(this);
            InitializeComponent();
            listener = new Listener(2014);
            listener.SocketAccepted += listener_SocketAccepted;
        }

        private void listener_SocketAccepted(Socket e)
        {
            var client = new Client(e);
            client.Received += client_Received;
            client.Disconnected += client_Disconnected;
            this.Invoke(() =>
            {
                string ip = client.Ip.ToString().Split(':')[0];
                var item = new ListViewItem(ip); // ip
                item.SubItems.Add(" "); // nickname
                item.SubItems.Add(" "); // status
                item.Tag = client;
                clientList.Items.Add(item);
                clients.Add(e);
            });
        }

        private void client_Disconnected(Client sender)
        {
            this.Invoke(() =>
            {
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client.Ip == sender.Ip)
                    {
                        txtReceive.Text += "<< " + clientList.Items[i].SubItems[1].Text + " Ha salido >>\r\n";
                        BroadcastData("RefreshChat|" + txtReceive.Text);
                        clientList.Items.RemoveAt(i);
                    }
                }
            });
        }

        private PrivateChat pChat;

        private void client_Received(Client sender, byte[] data)
        {
            this.Invoke(() =>
            {
                for (int i = 0; i < clientList.Items.Count; i++)
                {
                    var client = clientList.Items[i].Tag as Client;
                    if (client == null || client.Ip != sender.Ip) continue;
                    var command = Encoding.ASCII.GetString(data).Split('|');
                    switch (command[0])
                    {
                        case "Connect":
                            txtReceive.Text += "<< " + command[1] + " Ha entrado a la sala >>\r\n";
                            clientList.Items[i].SubItems[1].Text = command[1]; // nickname
                            clientList.Items[i].SubItems[2].Text = command[2]; // status
                            string users = string.Empty;
                            for (int j = 0; j < clientList.Items.Count; j++)
                            {
                                users += clientList.Items[j].SubItems[1].Text + "|";
                            }
                            BroadcastData("Users|" + users.TrimEnd('|'));
                            BroadcastData("RefreshChat|" + txtReceive.Text);
                            break;
                        case "Message":
                            txtReceive.Text += command[1] + " dice: " + command[2] + "\r\n";
                            BroadcastData("RefreshChat|" + txtReceive.Text);
                            break;
                        case "pMessage":
                            this.Invoke(() =>
                            {
                                pChat.txtReceive.Text += command[1] + " dice: " + command[2] + "\r\n";
                            });
                            break;
                        case "pChat":

                            break;
                    }
                }
            });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listener.Start();
            txIP.Text += " " + AddressFamily.InterNetwork;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            listener.Stop();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != string.Empty)
            {
                BroadcastData("Message|" + txtInput.Text);
                txtReceive.Text += txtInput.Text + "\r\n";
                txtInput.Text = "Admin dice: ";
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var client in from ListViewItem item in clientList.SelectedItems select (Client) item.Tag)
            {
                client.Send("Disconnect|");
            }
        }

        private void chatWithClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var client in from ListViewItem item in clientList.SelectedItems select (Client) item.Tag)
            {
                client.Send("Chat|");
                pChat = new PrivateChat(this);
                pChat.Show();
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            { 
                if (txtInput.Text == "Admin dice: ")
                {
                    e.Handled = true;
                }
            }
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            txtReceive.SelectionStart = txtReceive.TextLength;
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void txIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Cerrar la aplicación desconectará a todos los usuarios que se encuentren conectados, ¿Desea continuar?.","¿Salir del chat?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                return;
            }
            e.Cancel = true;
        }
    }
}