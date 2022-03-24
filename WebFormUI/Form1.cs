using Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebFormUI
{
    public partial class Form1 : Form
    {
        private readonly ICarService _carService;
        public Form1()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwCar.DataSource = _carService.GetCarDetails().Data;
        }

        private void dgwCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
