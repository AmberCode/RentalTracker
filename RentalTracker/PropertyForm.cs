using System;
using System.Windows.Forms;
using Common.Model;
using RentalTracker.Services.Property;

namespace RentalTracker
{
    public partial class PropertyForm : Form
    {

        private readonly IPropertyService _propertyService;
        private readonly PropertyModel _model;
        private ErrorProvider _nameErrorProvider;

        public PropertyForm(PropertyModel model)
        {
            InitializeComponent();

            Load += PropertyForm_Load;

            _nameErrorProvider = new ErrorProvider();

            _propertyService = new PropertyService();

            _model = model;
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            if (_model != null)
            {
                PropertyIdTextBox.Text = _model.Id.ToString();
                PropertyNameTextBox.Text = _model.PropertyName;
                AddressTextBox.Text = _model.Address;
                Address2TextBox.Text = _model.Address2;
                CityTextBox.Text = _model.City;
                StateTextBox.Text = _model.State;
                ZipCodeTextBox.Text = _model.ZipCode;
                OwnerNameTextBox.Text = _model.OwnerName;
            }
        }

        private void SavePropertyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsFormDataValid()) return;

                var model = new PropertyModel
                {
                    Id = string.IsNullOrEmpty(PropertyIdTextBox.Text) ? -1 : Convert.ToInt32(PropertyIdTextBox.Text),
                    PropertyName = PropertyNameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Address2 = Address2TextBox.Text,
                    City = CityTextBox.Text,
                    State = StateTextBox.Text,
                    ZipCode = ZipCodeTextBox.Text,
                    OwnerName = OwnerNameTextBox.Text
                };

                _propertyService.Save(model);

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

            _nameErrorProvider.SetError(PropertyNameTextBox, string.Empty);

            if (string.IsNullOrEmpty(PropertyNameTextBox.Text))
            {
                _nameErrorProvider.SetError(PropertyNameTextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(AddressTextBox, string.Empty);

            if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                _nameErrorProvider.SetError(AddressTextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(Address2TextBox, string.Empty);

            if (string.IsNullOrEmpty(Address2TextBox.Text))
            {
                _nameErrorProvider.SetError(Address2TextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(CityTextBox, string.Empty);

            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                _nameErrorProvider.SetError(CityTextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(StateTextBox, string.Empty);

            if (string.IsNullOrEmpty(StateTextBox.Text))
            {
                _nameErrorProvider.SetError(StateTextBox, emptyMessage);
                return false;
            }

            _nameErrorProvider.SetError(ZipCodeTextBox, string.Empty);

            if (string.IsNullOrEmpty(ZipCodeTextBox.Text))
            {
                _nameErrorProvider.SetError(ZipCodeTextBox, emptyMessage);
                return false;
            }
            else if (ZipCodeTextBox.Text.Length != 5)
            {
                _nameErrorProvider.SetError(ZipCodeTextBox, "5 digits");
                return false;
            }

            _nameErrorProvider.SetError(OwnerNameTextBox, string.Empty);

            if (string.IsNullOrEmpty(OwnerNameTextBox.Text))
            {
                _nameErrorProvider.SetError(OwnerNameTextBox, emptyMessage);
                return false;
            }
            
            return true;
        }
    }
}
