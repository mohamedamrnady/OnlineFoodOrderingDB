namespace OFODBGUI.Models;

partial class ManageOfferItemsForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.checkedListBoxItems = new System.Windows.Forms.CheckedListBox();
        this.buttonSave = new System.Windows.Forms.Button();
        this.buttonCancel = new System.Windows.Forms.Button();
        this.labelInstruction = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // checkedListBoxItems
        // 
        this.checkedListBoxItems.FormattingEnabled = true;
        this.checkedListBoxItems.Location = new System.Drawing.Point(12, 45);
        this.checkedListBoxItems.Name = "checkedListBoxItems";
        this.checkedListBoxItems.Size = new System.Drawing.Size(460, 312);
        this.checkedListBoxItems.TabIndex = 0;
        // 
        // buttonSave
        // 
        this.buttonSave.Location = new System.Drawing.Point(316, 363);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new System.Drawing.Size(75, 23);
        this.buttonSave.TabIndex = 1;
        this.buttonSave.Text = "Save";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new System.Drawing.Point(397, 363);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(75, 23);
        this.buttonCancel.TabIndex = 2;
        this.buttonCancel.Text = "Cancel";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
        // 
        // labelInstruction
        // 
        this.labelInstruction.AutoSize = true;
        this.labelInstruction.Location = new System.Drawing.Point(12, 9);
        this.labelInstruction.Name = "labelInstruction";
        this.labelInstruction.Size = new System.Drawing.Size(431, 15);
        this.labelInstruction.TabIndex = 3;
        this.labelInstruction.Text = "Select the menu items that this offer applies to:";
        // 
        // ManageOfferItemsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 401);
        this.Controls.Add(this.labelInstruction);
        this.Controls.Add(this.buttonCancel);
        this.Controls.Add(this.buttonSave);
        this.Controls.Add(this.checkedListBoxItems);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "ManageOfferItemsForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Manage Offer Items";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.CheckedListBox checkedListBoxItems;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label labelInstruction;
}
