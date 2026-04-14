namespace OFODBGUI.Models;

public partial class OfferUpdateForm : Form
{
    private SpecialOffer _offer;

    public OfferUpdateForm(SpecialOffer offer)
    {
        InitializeComponent();
        _offer = offer;
        PopulateFields();
    }

    private void PopulateFields()
    {
        textBoxId.Text = _offer.Offerid.ToString();
        textBoxName.Text = _offer.Offername;
        textBoxStartDate.Text = _offer.Startdate?.ToString("yyyy-MM-dd") ?? string.Empty;
        textBoxEndDate.Text = _offer.Enddate?.ToString("yyyy-MM-dd") ?? string.Empty;
        textBoxMinPoints.Text = _offer.Minpoints?.ToString() ?? string.Empty;
        textBoxDayOfWeek.Text = _offer.Dayoftheweek;
    }

    public SpecialOffer UpdatedOffer => _offer;

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Please enter an Offer Name.");
            return;
        }

        if (!TryGetDate(textBoxStartDate.Text, out DateOnly? startDate, "Start Date"))
        {
            return;
        }

        if (!TryGetDate(textBoxEndDate.Text, out DateOnly? endDate, "End Date"))
        {
            return;
        }

        if (!TryGetInt(textBoxMinPoints.Text, out int? minPoints, "Minimum Points"))
        {
            return;
        }

        try
        {
            using (var context = new NeondbContext())
            {
                var offerToUpdate = context.SpecialOffers.Find(_offer.Offerid);
                if (offerToUpdate != null)
                {
                    offerToUpdate.Offername = textBoxName.Text;
                    offerToUpdate.Startdate = startDate;
                    offerToUpdate.Enddate = endDate;
                    offerToUpdate.Minpoints = minPoints;
                    offerToUpdate.Dayoftheweek = textBoxDayOfWeek.Text;

                    context.SaveChanges();
                    _offer = offerToUpdate;
                    MessageBox.Show("Special offer updated successfully!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Offer not found in database.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating special offer: {ex.Message}");
        }
    }

    private bool TryGetDate(string input, out DateOnly? value, string fieldName)
    {
        value = null;

        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        if (DateOnly.TryParse(input, out var parsedDate))
        {
            value = parsedDate;
            return true;
        }

        MessageBox.Show($"Please enter a valid {fieldName} (for example 2026-04-14).");
        return false;
    }

    private bool TryGetInt(string input, out int? value, string fieldName)
    {
        value = null;

        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        if (int.TryParse(input, out var parsedInt))
        {
            value = parsedInt;
            return true;
        }

        MessageBox.Show($"Please enter a valid numeric value for {fieldName}.");
        return false;
    }
}

