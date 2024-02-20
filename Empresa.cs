using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Empresa
    {

        //Exercicio 1

        //Planes Lists
        List<Aviao> avioes = new List<Aviao>();
        List<AeronaveComercial> comercial = new List<AeronaveComercial>();
        List<AeronaveMercadorias> cargos = new List<AeronaveMercadorias>();
        List<AeronaveParticular> jets = new List<AeronaveParticular>();
        List<Avioneta> smallPlanes = new List<Avioneta>();

        //Booking Lists
        List<string> smallPlanesBooking = new List<string>();
        List<string> planesBooking = new List<string>();
        List<string> comercialBooking = new List<string>();
        List<string> cargosBooking = new List<string>();
        List<string> jetsBooking = new List<string>();

        //Exercicio 2

        //PLANE FILE
        public void AddAviao(Aviao aviao) //adicionar avião á lista
        {
            int ID;
            string Model;
            int Capacity;
            int Autonomy;
            string MaintenanceDate;
            string Activity;
            int EngineQuantity;
            string Brand;
            int ManufacturingYear;
            ID = aviao.Id;
            Model = aviao.Model;
            Capacity = aviao.Capacity;
            Autonomy = aviao.Autonomy;
            MaintenanceDate = aviao.MaintenanceDate;
            Activity = aviao.Activity;
            EngineQuantity = aviao.EngineQuantity;
            Brand = aviao.Brand;
            ManufacturingYear = aviao.ManufacturingYear;
            avioes.Add(aviao);
        }

        public void UpdateAviaoFile() //copia lista de avioes para o ficheiro avioes
        {
            StreamWriter file = new StreamWriter(@"planes.csv");

            foreach (Aviao aviao in avioes)
            {
                file.WriteLine(aviao.Id + ";" + aviao.Model + ";" + aviao.Capacity + ";" + aviao.Autonomy + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity + ";" + aviao.Brand + ";" + aviao.ManufacturingYear);
            }
            file.Close();
        }

        public void ImprimeAvioes()
        {
            foreach (Aviao aviao in avioes)
            {
                Console.WriteLine(aviao.ToString());
            }
        }

        //AERONAVECOMERCIAL FILE

        public void AddAeronaveComercial(AeronaveComercial aeronave)
        {
            comercial.Add(aeronave);
        }

        public void UpdateAeronaveComercialFile()
        {
            StreamWriter file = new StreamWriter(@"comercial.csv");

            foreach (AeronaveComercial aeronave in comercial)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.DailyFlightsNumber + ";" + aeronave.Airline);
            }
            file.Close();
        }

        public void ImprimeAeronavesComerciais()
        {
            foreach (AeronaveComercial aeronave in comercial)
            {
                Console.WriteLine(aeronave.ToString());
            }
        }

        //AERONAVEMERCADORIAS
        public void AddAeronaveMercadorias(AeronaveMercadorias aeronave)
        {
            cargos.Add(aeronave);
        }

        public void UpdateAeronaveMercadoriasFile()
        {
            StreamWriter file = new StreamWriter(@"cargos.csv");

            foreach (AeronaveMercadorias aeronave in cargos)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.CargoCapacity + ";" + aeronave.FreightValue);
            }
            file.Close();
        }

        public void ImprimeAeronavesMercadorias()
        {
            foreach (AeronaveMercadorias aeronave in cargos)
            {
                Console.WriteLine(aeronave.ToString());
            }
        }


        //AERONAVEPARTICULAR FILE
        public void AddAeronaveParticular(AeronaveParticular aeronave)
        {
            jets.Add(aeronave);
        }

        public void UpdateAeronaveParticularFile()
        {
            StreamWriter file = new StreamWriter(@"jets.csv");

            foreach (AeronaveParticular aeronave in jets)
            {
                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +
                               aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +
                               aeronave.EngineQuantity + ";" + aeronave.Brand + ";" + aeronave.ManufacturingYear + ";" +
                               aeronave.OwnersNumber + ";" + aeronave.FreightValue);
            }
            file.Close();
        }

        public void ImprimeAeronavesParticulares()
        {
            foreach (AeronaveParticular aeronave in jets)
            {
                Console.WriteLine(aeronave.ToString());
            }
        }

        //AVIONETA FILE

        public void AddAvioneta(Avioneta avioneta)
        {
            smallPlanes.Add(avioneta);
        }

        public void UpdateAvionetaFile()
        {
            StreamWriter file = new StreamWriter(@"smallPlanes.csv");

            foreach (Avioneta avioneta in smallPlanes)
            {
                file.WriteLine(avioneta.Id + ";" + avioneta.Model + ";" + avioneta.Capacity + ";" +
                               avioneta.Autonomy + ";" + avioneta.MaintenanceDate + ";" + avioneta.Activity + ";" +
                               avioneta.EngineQuantity + ";" + avioneta.Brand + ";" + avioneta.ManufacturingYear + ";" +
                               avioneta.MinimumTakeoffLandingArea + ";" + avioneta.FreightValue);
            }
            file.Close();
        }

        public void ImprimeAvionetas()
        {
            foreach (Avioneta avioneta in smallPlanes)
            {
                Console.WriteLine(avioneta.ToString());
            }
        }

        //Update Planes Files
        public void ReadAvioneta()
        {
            StreamReader file = new StreamReader(@"smallPlanes.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                Avioneta avioneta = new Avioneta(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), double.Parse(fields[9]), double.Parse(fields[10]));
                smallPlanes.Add(avioneta);
            }
            file.Close();

        }
        public void ReadAeronaveComercial()
        {
            StreamReader file = new StreamReader(@"comercial.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                AeronaveComercial aeronave = new AeronaveComercial(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), fields[10]);
                comercial.Add(aeronave);
            }
            file.Close();
        }
        public void ReadAeronaveMercadorias()
        {
            StreamReader file = new StreamReader(@"cargos.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                AeronaveMercadorias aeronave = new AeronaveMercadorias(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));
                cargos.Add(aeronave);
            }
            file.Close();
        }
        public void ReadAeronaveParticular()
        {
            StreamReader file = new StreamReader(@"jets.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                AeronaveParticular aeronave = new AeronaveParticular(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));
                jets.Add(aeronave);
            }
            file.Close();
        }
        public void ReadAviao()
        {
            StreamReader file = new StreamReader(@"planes.csv");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                Aviao aviao = new Aviao(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]));
                avioes.Add(aviao);
            }
            file.Close();
        }

        //Exercicio 2 

        //Exercicio2- a)

        public void ReadAllFiles()
        {
            ReadAeronaveComercial();
            ReadAeronaveMercadorias();
            ReadAeronaveParticular();
            ReadAviao();
            ReadAvioneta();
        }

        public int NumberOfPlanes() //Retorna o numero de avioes existentes para que nao se repita nenhum id
        {
            int planecounter = 0;
            foreach (Aviao aviao in avioes)
            {
                planecounter++;
            }
            foreach (AeronaveComercial comercialPlane in comercial)
            {
                planecounter++;
            }
            foreach (AeronaveMercadorias cargoPlane in cargos)
            {
                planecounter++;
            }
            foreach (AeronaveParticular jetPlane in jets)
            {
                planecounter++;
            }
            foreach (Avioneta smallPlane in smallPlanes)
            {
                planecounter++;
            }

            return planecounter + 1;
        }

        //Exercicio2 - b)

        //Change planes State

        public void ChangeAvionetaState(int id, string state)
        {
            //searches for the planes 
            foreach (Avioneta avioneta in smallPlanes)
            {
                //changes the state 
                if (avioneta.Id == id)
                {
                    avioneta.Activity = state;
                }
            }
            UpdateAvionetaFile(); //copies the list to the file
        }

        public void ChangeAviaoState(int id, string state)
        {
            //searches for the planes
            foreach (Aviao aviao in avioes)
            {
                //changes the state 
                if (aviao.Id == id)
                {
                    aviao.Activity = state;
                }
            }
            UpdateAviaoFile(); //copies the list to the file
        }

        public void ChangeAeronaveParticularState(int id, string state)
        {
            //searches for the planes
            foreach (AeronaveParticular jet in jets)
            {
                //changes the state 
                if (jet.Id == id)
                {
                    jet.Activity = state;
                }
            }

            UpdateAeronaveParticularFile(); //copies the list to the file
        }

        public void ChangeAeronaveMercadoriasState(int id, string state)
        {
            //searches for the planes
            foreach (AeronaveMercadorias cargo in cargos)
            {
                //changes the state 
                if (cargo.Id == id)
                {
                    cargo.Activity = state;
                }
            }

            UpdateAeronaveComercialFile(); //copies the list to the file
        }

        public void ChangeAeronaveComercialState(int id, string state)
        {
            //searches for the planes
            foreach (AeronaveComercial aeronavecomercial in comercial)
            {
                //changes the state 
                if (aeronavecomercial.Id == id)
                {
                    aeronavecomercial.Activity = state;
                    break;
                }
            }
            UpdateAeronaveComercialFile(); //copies the list to the file
        }

        //Copies Every list from the previous list to the actual list

        public void copyList(Empresa copied)
        {
            avioes = copied.avioes;
            comercial = copied.comercial;
            cargos = copied.cargos;
            jets = copied.jets;
            smallPlanes = copied.smallPlanes;
        }

        //LOGIN SYSTEM

        public bool VerifiesLogin(string username, string password)
        {
            //If the login data are correct returns true else returns false

            StreamReader file = new StreamReader(@"users.csv");

            string line;

            //Reads the entire file line by line
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');

                //if the username and the password match
                if (fields[0] == username && fields[1] == password)
                {
                    return true; //returns true
                }
            }

            file.Close();

            return false; //if the user or password are wrong return false
        }
        //Booking

        public void UpdateAvionetaBooking(string date1, string date2)

        {

            StreamWriter file = new StreamWriter(@"smallPlanesBooking.csv");

            foreach (Avioneta avioneta in smallPlanes)

            {

                file.WriteLine(avioneta.Id + ";" + avioneta.Model + ";" + date1 + ";" + date2);
                break;

            }

            file.Close();

        }
        public void ReadAvionetaBooking()

        {

            StreamReader file = new StreamReader(@"smallPlanesBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                int id;
                string model;
                string date1, date2;



                smallPlanesBooking.Add(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + fields[3]);

            }

            file.Close();

        }
        public void UpdateAviaoBooking()

        {

            StreamWriter file = new StreamWriter(@"smallPlanesBooking.csv");

            foreach (Aviao aviao in avioes)

            {

                file.WriteLine(aviao.Id + ";" + aviao.Model + ";" + aviao.Capacity + ";" + aviao.Autonomy + ";" + aviao.MaintenanceDate + ";" + aviao.Activity + ";" + aviao.EngineQuantity + ";" + aviao.Brand + ";" + aviao.ManufacturingYear);

            }

            file.Close();

        }
        public void ReadAviaoBooking()

        {

            StreamReader file = new StreamReader(@"planesBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                Aviao aviao = new Aviao(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]));

                planesBooking.Add(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + fields[3]);

            }

            file.Close();

        }
        public void UpdateAeronaveComercialBooking()

        {

            StreamWriter file = new StreamWriter(@"comercialBooking.csv");

            foreach (AeronaveComercial aeronave in comercial)

            {

                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +

                                                  aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +

                                               aeronave.EngineQuantity + ";" + aeronave.Brand);

            }
            file.Close();
        }
        public void ReadAeronaveComercialBooking()

        {

            StreamReader file = new StreamReader(@"comercialBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                AeronaveComercial aeronave = new AeronaveComercial(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), fields[10]);

                comercialBooking.Add(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + fields[3]);

            }

            file.Close();

        }
        public void UpdateAeronaveMercadoriasBooking()

        {

            StreamWriter file = new StreamWriter(@"cargoBooking.csv");

            foreach (AeronaveMercadorias aeronave in cargos)

            {

                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +

                                                                     aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +

                                                                                                                   aeronave.EngineQuantity + ";" + aeronave.Brand);

            }
            file.Close();
        }
        public void ReadAeronaveMercadoriasBooking()

        {

            StreamReader file = new StreamReader(@"cargoBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                AeronaveMercadorias aeronave = new AeronaveMercadorias(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));

                cargosBooking.Add(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + fields[3]);

            }

            file.Close();

        }
        public void UpdateAeronaveParticularBooking()

        {

            StreamWriter file = new StreamWriter(@"jetsBooking.csv");

            foreach (AeronaveParticular aeronave in jets)

            {

                file.WriteLine(aeronave.Id + ";" + aeronave.Model + ";" + aeronave.Capacity + ";" +

                                                                     aeronave.Autonomy + ";" + aeronave.MaintenanceDate + ";" + aeronave.Activity + ";" +

                                                                                                                   aeronave.EngineQuantity + ";" + aeronave.Brand);

            }
            file.Close();
        }
        public void ReadAeronaveParticularBooking()

        {

            StreamReader file = new StreamReader(@"jetsBooking.csv");

            string line;

            while ((line = file.ReadLine()) != null)

            {

                string[] fields = line.Split(';');

                AeronaveParticular aeronave = new AeronaveParticular(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], fields[5], int.Parse(fields[6]), fields[7], int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]));

                jetsBooking.Add(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + fields[3]);

            }

            file.Close();

        }
        public void ReadBooking()
        {
            ReadAvionetaBooking();
            ReadAviaoBooking();
            ReadAeronaveComercialBooking();
            ReadAeronaveMercadoriasBooking();
            ReadAeronaveParticularBooking();
        }


        public string SearchId(int id, string date1, string date2, DateTime datetime1, DateTime datetime2)
        {
            foreach (Aviao a in avioes)
            {
                if (a.Id == id)
                {
                    registerAviaoBooking(id, datetime1, datetime2);
                    return "Planes";
                }
            }
            foreach (AeronaveComercial a in comercial)
            {
                if (a.Id == id)
                {
                    registerComercialBooking(id, datetime1, datetime2);
                    return "CommercialPlane";
                }
            }
            foreach (AeronaveMercadorias a in cargos)
            {
                if (a.Id == id)
                {
                    registerCargoBooking(id, a.FreightValue, datetime1, datetime2);
                    registerFrete(id, a.FreightValue, datetime1, datetime2);
                    return "CargoPlane";
                }
            }
            foreach (AeronaveParticular a in jets)
            {
                if (a.Id == id)
                {
                    registerParticularBooking(id, a.FreightValue, datetime1, datetime2);
                    registerFrete(id, a.FreightValue, datetime1, datetime2);
                    return "JetPlane";
                }
            }
            foreach (Avioneta a in smallPlanes)
            {
                if (a.Id == id)
                {
                    registerAvionetaBooking(id, a.FreightValue, datetime1, datetime2);
                    registerFrete(id, a.FreightValue, datetime1, datetime2);
                    return "SmallPlane";
                }
            }
            return "Not Found";
        }

        public void registerAvionetaBooking(int id, double value, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"smallPlanesBooking.csv", true);
            file.WriteLine(id.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        public void registerComercialBooking(int id, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"comercialBooking.csv", true);
            file.WriteLine(id.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        public void registerCargoBooking(int id, double value, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"cargoBooking.csv", true);
            file.WriteLine(id.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        public void registerParticularBooking(int id, double value, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"jetsBooking.csv", true);
            file.WriteLine(id.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        public void registerAviaoBooking(int id, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"planesBooking.csv", true);
            file.WriteLine(id.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        public void registerFrete(int id, double value, DateTime date1, DateTime date2)
        {
            StreamWriter file = new StreamWriter(@"freight.csv", true);

            string dias = ((date1 - date2).TotalDays).ToString();
            //int daysNumber = int.Parse(dias);
            //daysNumber = Math.Abs(daysNumber);
            //value = daysNumber * value;    
            file.WriteLine(id.ToString() + ";" + value.ToString() + ";" + date1.ToString("dd/MM/yyyy") + "; " + date2.ToString("dd/MM/yyyy"));
            file.Close();
        }

        //Calcular Frete

        public double Search(int id, int numberOfDays)
        {
            double value;

            foreach (AeronaveMercadorias plane in cargos)
            {
                if (plane.Id == id)
                {
                    return plane.FreightValue * numberOfDays;
                }
            }
            foreach (AeronaveParticular plane in jets)
            {
                if (plane.Id == id)
                {
                    return plane.FreightValue * numberOfDays;
                }
            }
            return 0;
        }

        public string PlaneType(int id)
        {
            foreach (AeronaveMercadorias plane in cargos)
            {
                if (plane.Id == id)
                {
                    return "Cargo";
                }
            }
            foreach (AeronaveParticular plane in jets)
            {
                if (plane.Id == id)
                {
                    return "Jet";
                }
            }
            return "Not Found";
        }
        public string AdvanceOneDay(string date1)
        {

            DateTime date;
            date = DateTime.Parse(date1);
            date = date.AddDays(1);
            return date.ToString("dd/MM/yyyy");


        }
        public void PlaneStatusBeginS(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"smallPlanesBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[1]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Booked");
                }

            }
            file.Close();



        }
        public void PlaneStatusEndS(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"smallPlanesBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[2]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Available");
                }

            }
            file.Close();
        }
        public void PlaneStatusBeginC(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"comercialBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[1]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Booked");
                }

            }
            file.Close();

        }
        public void PlaneStatusEndC(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"comercialBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[2]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Available");
                }

            }
            file.Close();
        }
        public void PlaneStatusBeginM(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"cargoBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[1]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Booked");
                }

            }
            file.Close();

        }
        public void PlaneStatusEndM(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"cargoBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[2]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Available");
                }

            }
            file.Close();
        }
        public void PlaneStatusBeginJ(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"jetsBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[1]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Booked");
                }

            }
            file.Close();

        }
        public void PlaneStatusEndJ(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"jetsBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[2]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Available");
                }

            }
            file.Close();
        }
        public void PlaneStatusBeginA(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"planesBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[1]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Booked");
                }

            }
            file.Close();

        }
        public void PlaneStatusEndA(string date2)
        {
            DateTime date;
            date = DateTime.Parse(date2);
            StreamReader file = new StreamReader(@"planesBooking.csv");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(';');
                DateTime date1 = DateTime.Parse(fields[2]);
                if (date1 == date)
                {
                    ChangeAvionetaState(int.Parse(fields[0]), "Available");
                }

            }
            file.Close();
        }
    }
 }
