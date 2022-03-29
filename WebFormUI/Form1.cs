using Business.Concrete;
using System;
using System.CodeDom;
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
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebFormUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _brandService = new BrandManager(new EfBrandDal());
            _colorService = new ColorManager(new EfColorDal());

        }

        private IBrandService _brandService;
        private ICarService _carService;
        private IColorService _colorService;

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCarModels();
            ListBrands();
            ListCars();
            ListModelYears();
            ListColors();
            //cbxModelYearAdd.SelectedIndex = -1;
        }

        private void ListCars()
        {
            dgwCar.DataSource = _carService.GetAll().Data;
        }
        //private void ListCarsByBrand(int brandId)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        dgwCar.DataSource = context.Cars.Where(p => p.BrandId == brandId).ToList();
        //    }
        //}


        private void ListCarModels()
        {

            cbxCar.DataSource = _carService.GetAll().Data;
            cbxCar.DisplayMember = "ModelName";
            cbxCar.ValueMember = "CarId";
            cbxCar.Text = "Model Seç";

        }

        private void ListBrands()
        {
            cbxBrand.DataSource = _brandService.GetAll().Data;
            cbxBrand.DisplayMember = "BrandName";
            cbxBrand.ValueMember = "BrandId";
            cbxBrand.Text = "Marka Seç";

            cbxBrandId.DataSource = _brandService.GetAll().Data;
            cbxBrandId.DisplayMember = "BrandName";
            cbxBrandId.ValueMember = "BrandId";
            cbxBrandId.Text = "Marka Seç";
        }

        private void ListModelYears()
        {
            cbxModelYearAdd.DataSource= Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList();
            cbxModelYearAdd.Text= "Model Yılı";
            //cbxModelYearAdd.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ListColors()
        {
            cbxColorId.DataSource = _colorService.GetAll().Data;
            cbxColorId.DisplayMember = "ColorName";
            cbxColorId.ValueMember = "ColorId";
            cbxColorId.Text = "Renk Seç";
        }
        private void cbxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwCar.DataSource = _carService.GetCarsByBrand(Convert.ToInt32(cbxBrand.SelectedValue)).Data;
                //ListCarsByBrand(Convert.ToInt32(cbxBrand.SelectedValue));
            }
            catch
            {
             
            }
        }

        private void tbxModelSearch_TextChanged(object sender, EventArgs e)
        {
            dgwCar.DataSource = _carService.GetCarsByCarModel(tbxModelSearch.Text).Data;
        }
        [ValidationAspect(typeof(CarValidator))]
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.Add(new Car
                {
                    BrandId = Convert.ToInt32(cbxBrandId.SelectedValue),
                    ModelName = tbxModelAdd.Text,
                    ColorId = Convert.ToInt32(cbxColorId.SelectedValue),
                    ModelYear = Convert.ToInt32(cbxModelYearAdd.SelectedValue),
                    DailyPrice = Convert.ToDecimal(tbxDailyPrice.Text),
                    Description = tbxDescription.Text
                });
                MessageBox.Show(Messages.CarAdded);
                ListCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
        
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.Update(new Car
                {
                    CarId = Convert.ToInt32(dgwCar.CurrentRow.Cells[0].Value),
                    BrandId = Convert.ToInt32(cbxBrandId.SelectedValue),
                    ModelName = tbxModelAdd.Text,
                    ColorId = Convert.ToInt32(cbxColorId.SelectedValue),
                    ModelYear = Convert.ToInt32(cbxModelYearAdd.SelectedValue),
                    DailyPrice = Convert.ToDecimal(tbxDailyPrice.Text),
                    Description = tbxDescription.Text
                });
                MessageBox.Show(Messages.CarUpdated);
                ListCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.Delete(new Car
                {
                    CarId = Convert.ToInt32(dgwCar.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show(Messages.CarDeleted);
                ListCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCar.CurrentRow;
            cbxBrandId.SelectedValue = row.Cells[1].Value;
            cbxColorId.SelectedValue = row.Cells[2].Value;
            tbxModelAdd.Text = row.Cells[3].Value.ToString();
            cbxModelYearAdd.SelectedItem = row.Cells[4].Value;
            tbxDailyPrice.Text = row.Cells[5].Value.ToString();
            tbxDescription.Text = row.Cells[6].Value.ToString();

        }
    }
}
