#region Código hecho por Jhonatan Torres
#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region ENTIDAD
namespace Negocio.Entidades
{
    #region Class
    public class E_LogroDeportistaCampeonato
    {
        #region Atributos
        public Int64 ID_LOGRO_CAMPEONATO { get; set; }
        public Int64 ID_CAMPEONATO { get; set; }
        public Int64 ID_CATEGORIA_CINTURON { get; set; }
        public Int64 ID_DEPORTISTA { get; set; }
        public Int64 ID_LOGRO_COMBATE { get; set; }
        public Int64 ID_LOGRO_POOMSAE { get; set; }
        public Int64 ID_LOGRO_EXHIBICION { get; set; }
        public String MEDALLA_LOGRADA { get; set; }
        public String FOTO_PODIUM { get; set; }
        public Int64 COMBATES_DISPUTADOS { get; set; }
        public Int64 PUESTO_ALCANZADO { get; set; }
        public Int64 TOTAL_PARTICIPANTES_CATEGORIA { get; set; }
        public Decimal PUNTAJE_RAIKING { get; set; }
        #endregion

        #region Constructor
        public E_LogroDeportistaCampeonato()
        {
        }
        #endregion

        #region Métodos
        public E_LogroDeportistaCampeonato(Int64 pID_LOGRO_CAMPEONATO, Int64 pID_CAMPEONATO, Int64 pID_CATEGORIA_CINTURON, Int64 pID_DEPORTISTA, Int64 pID_LOGRO_COMBATE, Int64 pID_LOGRO_POOMSAE, Int64 pID_LOGRO_EXHIBICION, String pMEDALLA_LOGRADA, String pFOTO_PODIUM, Int64 pPUESTO_ALCANZADO, Int64 pTOTAL_PARTICIPANTES_CATEGORIA, Decimal pPUNTAJE_RAIKING)
        {
            this.ID_LOGRO_CAMPEONATO = pID_LOGRO_CAMPEONATO;
            this.ID_CAMPEONATO = pID_CAMPEONATO;
            this.ID_CATEGORIA_CINTURON = pID_CATEGORIA_CINTURON;
            this.ID_DEPORTISTA = pID_DEPORTISTA;
            this.ID_CAMPEONATO = pID_CAMPEONATO;
            this.ID_LOGRO_COMBATE = pID_LOGRO_COMBATE;
            this.ID_LOGRO_POOMSAE = pID_LOGRO_POOMSAE;
            this.ID_LOGRO_EXHIBICION = pID_LOGRO_EXHIBICION;
            this.MEDALLA_LOGRADA = pMEDALLA_LOGRADA;
            this.FOTO_PODIUM = pFOTO_PODIUM;
            this.PUESTO_ALCANZADO = pPUESTO_ALCANZADO;
            this.TOTAL_PARTICIPANTES_CATEGORIA = pTOTAL_PARTICIPANTES_CATEGORIA;
            this.PUNTAJE_RAIKING = pPUNTAJE_RAIKING;
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
