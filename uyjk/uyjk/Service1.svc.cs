using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace uyjk
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Serviceref.Service1Client serv = new Serviceref.Service1Client();
        uyjk.model.DatabaseController dbController = new uyjk.model.DatabaseController();
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        
        

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbController.connectDatabase();
            
            return doesItWork;
        }

        public int DelCar(int carid)
        {
            int affected = dbController.DeleteCar(carid);
            return affected;
        }
        public int SetCount(int id)
        {
            id = dbController.setidcount(id);
            return id;
        }
        public int saveAutoIntoDatabase(Auto newAuto)
        {
            int affected = dbController.saveAutoIntoDatabase(newAuto);
            return affected;
        }

        public List<Merkki> getAllAutoMakersFromDatabase1()
        {
            
            return dbController.getAllAutoMakersFromDatabase();
        }

        public List<Malli> getAutoModelsByMakerId(int makerId)
        {
            
            return dbController.getAutoModelsByMakerId(makerId);
        }

        public List<polttoaine> GetAutoFuels(int id)
        {
            return dbController.GetAutoFuels(id);
        }

        public List<vari> GetAutoColors()
        {
            return dbController.GetAutoColors();
        }

        public void AddAutos(Auto car)
        {
            dbController.saveAutoIntoDatabase(car);
        }

        public Auto GetNextAuto(int id)
        {
            var returnable = dbController.GetNextAuto(id);
            if (returnable.Id == 0)
            {
                returnable = dbController.GetNextAuto(id);
            }
            return returnable;
        }

        public Auto GetPrevious(int id)
        {
            var returnable = dbController.GetPrevious(id);
            if (returnable.Id == 0)
            {
                returnable = dbController.GetPrevious(id);
            }
            return returnable;
        }

        public Auto HaeMerkkiJaMalliJaVariJaPolttoaine(int merkki, int malli, int vari, int polttoaine)
        {
            return dbController.HaeMerkkiJaMalliJaVariJaPolttoaine(merkki, malli, vari, polttoaine);
        }
    }
}
