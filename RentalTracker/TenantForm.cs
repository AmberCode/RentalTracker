using Common.Model;
using RentalTracker.Services.Tenant;
using System;
using System.Windows.Forms;

namespace RentalTracker
{
    public partial class TenantForm : Form
    {
        private readonly ITenantService _tenantService;
        private readonly TenantModel _model;
        private readonly int _propertyId;
        private ErrorProvider _nameErrorProvider;

        public TenantForm(TenantModel model, int propertyId)
        {
            InitializeComponent();
            Load += TenantForm_Load; ;

            _nameErrorProvider = new ErrorProvider();

            _tenantService = new TenantService();

            _model = model;
            _propertyId = propertyId;
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            if (_model != null)
            {
                TenantIdTextBox.Text = _model.Id.ToString();
                NameTextBox.Text = _model.Name;
                StartDateDatePicker.Value = _model.StartDate;
                EndDateDatePicker.Value = _model.EndDate;
                RentalPriceTextBox.Text = _model.RentalPrice.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsFormDataValid()) return;

                var model = new TenantModel
                {
                    Id = _model == null ? -1 : _model.Id,
                    PropertyId = _model == null ? _propertyId : _model.PropertyId,
                    Name = NameTextBox.Text,
                    StartDate = StartDateDatePicker.Value,
                    EndDate = EndDateDatePicker.Value,
                    RentalPrice = Convert.ToDecimal(RentalPriceTextBox.Text),
                };

                _tenantService.Save(model);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                //log ex
                MessageBox.Show("System error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool IsFormDataValid()
        {
            var emptyMessage = "It's empty";

            _nameErrorProvider.SetError(NameTextBox, string.Empty);

            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                _nameErrorProvider.SetError(NameTextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(StartDateDatePicker, string.Empty);

            if (StartDateDatePicker.Value.Date > EndDateDatePicker.Value.Date)
            {
                _nameErrorProvider.SetError(StartDateDatePicker, "Start date is greater than end date");
                return false;
            }

            _nameErrorProvider.SetError(RentalPriceTextBox, string.Empty);
            decimal priceResult;

            if (string.IsNullOrEmpty(RentalPriceTextBox.Text))
            {
                _nameErrorProvider.SetError(RentalPriceTextBox, emptyMessage);
                return false;
            }
            else if (!decimal.TryParse(RentalPriceTextBox.Text, out priceResult))
            {
                _nameErrorProvider.SetError(RentalPriceTextBox, "Incorrect price format e.g.: 222.33");
                return false;
            }

            return true;
        }
    }
}
