using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Empresa empresa)
        {
            InitializeComponent();
            empresaComercial = empresa;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        Empresa empresaComercial = new Empresa();

        private void Comercial_add_Click_1(object sender, EventArgs e)
        {
            AeronaveComercial aeronaveComercial = new AeronaveComercial();
            aeronaveComercial.Id = empresaComercial.NumberOfPlanes();
            aeronaveComercial.Model = Comercial_model.Text;
            aeronaveComercial.Capacity = Convert.ToInt32(Comercial_capacity.Text);
            aeronaveComercial.Autonomy = Convert.ToInt32(Comercial_autonomy.Text);
            aeronaveComercial.MaintenanceDate = Comercial_maintenanceDate.Text;
            aeronaveComercial.Activity = Comercial_activity.Text;
            aeronaveComercial.EngineQuantity = Convert.ToInt32(Comercial_engineQuantity.Text);
            aeronaveComercial.Brand = Comercial_brand.Text;
            aeronaveComercial.ManufacturingYear = Convert.ToInt32(Comercial_manufacturingYear.Text);
            aeronaveComercial.DailyFlightsNumber = Convert.ToInt32(Comercial_dailyFlightsNumber.Text);
            aeronaveComercial.Airline = Comercial_airline.Text;
            empresaComercial.AddAeronaveComercial(aeronaveComercial);
            empresaComercial.UpdateAeronaveComercialFile();
            MessageBox.Show("Aviaoadicionado");
        }


        /*
         
        Adicionar aviaoMercadorias

        private void Mercadorias_add_Click(object sender, EventArgs e)
        {
            AeronaveMercadorias aeronaveMercadorias = new AeronaveMercadorias();
            aeronaveComercial.Id = empresaComercial.NumberOfPlanes();
            aeronaveMercadorias.Model = Mercadorias_model.Text;
            aeronaveMercadorias.Capacity = Convert.ToInt32(Mercadorias_capacity.Text);
            aeronaveMercadorias.Autonomy = Convert.ToInt32(Mercadorias_autonomy.Text);
            aeronaveMercadorias.MaintenanceDate = Mercadorias_maintenanceDate.Text;
            aeronaveMercadorias.Activity = Mercadorias_activity.Text;
            aeronaveMercadorias.EngineQuantity = Convert.ToInt32(Mercadorias_engineQuantity.Text);
            aeronaveMercadorias.Brand = Mercadorias_brand.Text;
            aeronaveMercadorias.ManufacturingYear = Convert.ToInt32(Mercadorias_manufacturingYear.Text);
            aeronaveMercadorias.CargoCapacity = Convert.ToInt32(Mercadorias_cargoCapacity.Text);
            aeronaveMercadorias.FreightValue = Convert.ToDouble(Mercadorias_freightValue.Text);

            empresaMercadorias.AddAeronaveMercadorias(aeronaveMercadorias);
            empresaMercadorias.UpdateAeronaveMercadoriasFile();
            MessageBox.Show("Aeronave de mercadorias adicionada com sucesso");
        }

        private void Particular_add_Click(object sender, EventArgs e)
        {
         Adicionar Particular


            AeronaveParticular aeronaveParticular = new AeronaveParticular();
            aeronaveComercial.Id = empresaComercial.NumberOfPlanes();
            aeronaveParticular.Model = Particular_model.Text;
            aeronaveParticular.Capacity = Convert.ToInt32(Particular_capacity.Text);
            aeronaveParticular.Autonomy = Convert.ToInt32(Particular_autonomy.Text);
            aeronaveParticular.MaintenanceDate = Particular_maintenanceDate.Text;
            aeronaveParticular.Activity = Particular_activity.Text;
            aeronaveParticular.EngineQuantity = Convert.ToInt32(Particular_engineQuantity.Text);
            aeronaveParticular.Brand = Particular_brand.Text;
            aeronaveParticular.ManufacturingYear = Convert.ToInt32(Particular_manufacturingYear.Text);
            aeronaveParticular.OwnersNumber = Convert.ToInt32(Particular_ownersNumber.Text);
            aeronaveParticular.FreightValue = Convert.ToDouble(Particular_freightValue.Text);

            empresaParticular.AddAeronaveParticular(aeronaveParticular);
            empresaParticular.UpdateAeronaveParticularFile();
            MessageBox.Show("Aeronave particular adicionada com sucesso");
        }

        private void Avioneta_add_Click(object sender, EventArgs e)
        {

        Adicionar Avioneta

            Avioneta avioneta = new Avioneta();
            aeronaveComercial.Id = empresaComercial.NumberOfPlanes();
            avioneta.Model = Avioneta_model.Text;
            avioneta.Capacity = Convert.ToInt32(Avioneta_capacity.Text);
            avioneta.Autonomy = Convert.ToInt32(Avioneta_autonomy.Text);
            avioneta.MaintenanceDate = Avioneta_maintenanceDate.Text;
            avioneta.Activity = Avioneta_activity.Text;
            avioneta.EngineQuantity = Convert.ToInt32(Avioneta_engineQuantity.Text);
            avioneta.Brand = Avioneta_brand.Text;
            avioneta.ManufacturingYear = Convert.ToInt32(Avioneta_manufacturingYear.Text);
            avioneta.MinimumTakeoffLandingArea = Convert.ToDouble(Avioneta_minimumTakeoffLandingArea.Text);
            avioneta.FreightValue = Convert.ToDouble(Avioneta_freightValue.Text);

            empresaAvioneta.AddAvioneta(avioneta);
            empresaAvioneta.UpdateAvionetaFile();
            MessageBox.Show("Avioneta adicionada com sucesso");

        }

        private void Aviao_add_Click(object sender, EventArgs e)
        {

        Adicionar Aviao

            Aviao aviao = new Aviao();
            aeronaveComercial.Id = empresaComercial.NumberOfPlanes();
            aviao.Model = Aviao_model.Text;
            aviao.Capacity = Convert.ToInt32(Aviao_capacity.Text);
            aviao.Autonomy = Convert.ToInt32(Aviao_autonomy.Text);
            aviao.MaintenanceDate = Aviao_maintenanceDate.Text;
            aviao.Activity = Aviao_activity.Text;
            aviao.EngineQuantity = Convert.ToInt32(Aviao_engineQuantity.Text);
            aviao.Brand = Aviao_brand.Text;
            aviao.ManufacturingYear = Convert.ToInt32(Aviao_manufacturingYear.Text);

            empresaAviao.AddAviao(aviao);
            empresaAviao.UpdateAviaoFile();
            MessageBox.Show("Aviao adicionado com sucesso");
        }
        */



    }
}
