using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace uyjk
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        int DelCar(int carid);

        [OperationContract]
        int saveAutoIntoDatabase(Auto newAuto);

        [OperationContract]
        List<Merkki> getAllAutoMakersFromDatabase1();

        [OperationContract]
        List<Malli> getAutoModelsByMakerId(int makerId);

        [OperationContract]
        List<polttoaine> GetAutoFuels(int id);

        [OperationContract]
        List<vari> GetAutoColors();

        [OperationContract]
        Auto GetNextAuto(int carid);

        [OperationContract]
        int SetCount(int id);

        [OperationContract]
        Auto GetPrevious(int carid);

        //[OperationContract]
        //Auto.model.Auto HaeMerkkiJaMalliJaVariJaPolttoaine(int merkki, int malli, int vari, int polttoaine);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

     
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

      
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    public class Auto
    {
        int id;
        decimal hinta;
        DateTime pvm;
        decimal mottoritila;
        int mittarilukema;
        int merkki;
        int malli;
        int color;
        int fuel;


        public int Id { get => id; set => id = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime Pvm { get => pvm; set => pvm = value; }
        public decimal Mottoritila { get => mottoritila; set => mottoritila = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        [DataMember]
         public int Merkki { get => merkki; set => merkki = value; }
        public int Malli { get => malli; set => malli = value; }
        public int Color { get => color; set => color = value; }
        public int Fuel { get => fuel; set => fuel = value; }
    }
    public class Merkki
    {
        int id;
        string valmistaja;

        public int Id { get => id; set => id = value; }
        public string Valmistaja { get => valmistaja; set => valmistaja = value; }
    }
    public class Malli


    {
        int malliId;
        string malliname;
        int merkkiId;

        public int MalliId { get => malliId; set => malliId = value; }
        public string Malliname { get => malliname; set => malliname = value; }
        public int MerkkiId { get => merkkiId; set => merkkiId = value; }
    }
    public class polttoaine
    {
        int fuelId;
        string fuelName;

        public int FuelId { get => fuelId; set => fuelId = value; }
        public string FuelName { get => fuelName; set => fuelName = value; }
    }
    public class vari
    {
        int colorId;
        string colorName;

        public int ColorId { get => colorId; set => colorId = value; }
        public string ColorName { get => colorName; set => colorName = value; }
    }
}
