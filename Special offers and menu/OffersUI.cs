namespace OFODBGUI.Models;

public partial class OffersUI : Form
{
    public OffersUI()
    {
        InitializeComponent();
    }
     private void LogAction(string message)
    {
        outputbox.AppendText($"{message}{Environment.NewLine}");
        outputbox.ScrollToCaret();
    }

    private void insert_Click(object sender, EventArgs e)
    {
        using (var form = new OfferInsertForm())
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                load_Table(sender, e);
                if (form.NewOffer != null)
                {
                    LogAction($"inserted {form.NewOffer.Offername}");
                }
            }
        }
    }

    private void update_Click(object sender, EventArgs e)
    {
        if (dataview.CurrentRow != null)
        {
            var selectedItem = (SpecialOffer)dataview.CurrentRow.DataBoundItem;
            using (var form = new OfferUpdateForm(selectedItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    load_Table(sender, e);
                    LogAction($"updated {form.UpdatedOffer.Offername}");
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a row to update.");
        }
    }

    private void delete_Click(object sender, EventArgs e)
    {
        if (dataview.CurrentRow != null)
        {
            var selectedItem = (SpecialOffer)dataview.CurrentRow.DataBoundItem;
            var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedItem.Offername}?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var context = new NeondbContext())
                    {
                        var itemToDelete = context.MenuItems.Find(selectedItem.Offerid);
                        if (itemToDelete != null)
                        {
                            context.MenuItems.Remove(itemToDelete);
                            context.SaveChanges();
                            MessageBox.Show("Special offer deleted successfully!");
                            LogAction($"deleted {selectedItem.Offername}");
                            load_Table(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting special offer: {ex.Message}");
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a row to delete.");
        }
    }

    private void OffersUI_Load(object sender, EventArgs e)
    {
        load_Table(sender, e);
    }

    private void load_Table(object sender, EventArgs e)
    {
        using (var context = new NeondbContext())
        {
            var data = context.SpecialOffers.ToList(); 

            dataview.DataSource = data;
        }
    }
}