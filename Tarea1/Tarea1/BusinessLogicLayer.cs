using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class BusinessLogicLayer
    {
        private DataAccessLayer dataAccessLayer;
        public BusinessLogicLayer()
        {
            dataAccessLayer = new DataAccessLayer();
        }
        public Tutor GuardarTutor(Tutor tutor)
        {
            dataAccessLayer.InsertarTutor(tutor);
            return tutor;
        }
        public Tutor ModificarTutor(Tutor tutor)
        {
            dataAccessLayer.ActualizarTutor(tutor);
            return tutor;
        }
        public void EliminarTutor(string ID_tutor)
        {
            dataAccessLayer.ElimnarTutor(ID_tutor);
        }
        public List<Tutor> GetTutores(string texto_buscar=null)
        {
            return dataAccessLayer.GetTutores(texto_buscar);
        }
    }
}
