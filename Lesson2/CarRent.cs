using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{
		public CarRent()
		{
			InitializeComponent();     
		}
        CarService _CarService = new CarService();
        Car selectedCar = new Car("","");
        private System.DateTime _DateFrom = new System.DateTime();
        private System.DateTime _DateTo = new System.DateTime();
             
        private void CarRent_Load(object sender, System.EventArgs e)
        {
            RefreshListOfCars();
        }

        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = selectedCar.GetDescription();
        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
            RefreshListOfCars();
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
            RefreshListOfCars();
        }

        private void RefreshListOfCars()
        {
            _DateTo = dateTimePicker1.Value;
            _DateFrom = dateTimePicker2.Value;
            CarList.Items.Clear();
            CarList.Items.AddRange(_CarService.GetAvailableCars(_DateFrom, _DateTo).ToArray());
            //if (CarList.Items.Count > 0) CarList.SelectedItem = CarList.Items[0];
        }
        private void MakeAnOrderButton_Click(object sender, System.EventArgs e)
        {
            Rent NewRent = new Rent(selectedCar, _DateFrom, _DateTo);
            _CarService.MakeRent(NewRent);
            RefreshListOfCars();
        }
    }
}
