namespace EF_RestaurantReservation.Forms.Reservation;

partial class FrmReservation
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnDelete = new Button();
        dgvReservation = new DataGridView();
        dtpRes_Date = new DateTimePicker();
        label2 = new Label();
        label3 = new Label();
        label1 = new Label();
        cmbCustomer = new ComboBox();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
        SuspendLayout();
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(129, 157);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(158, 37);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // dgvReservation
        // 
        dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvReservation.Location = new Point(515, 66);
        dgvReservation.Name = "dgvReservation";
        dgvReservation.RowHeadersWidth = 51;
        dgvReservation.Size = new Size(671, 409);
        dgvReservation.TabIndex = 10;
        dgvReservation.CellClick += dgvReservation_CellClick_1;
        // 
        // dtpRes_Date
        // 
        dtpRes_Date.Location = new Point(129, 106);
        dtpRes_Date.Name = "dtpRes_Date";
        dtpRes_Date.Size = new Size(352, 31);
        dtpRes_Date.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(24, 112);
        label2.Name = "label2";
        label2.Size = new Size(53, 25);
        label2.TabIndex = 6;
        label2.Text = "Date:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(515, 27);
        label3.Name = "label3";
        label3.Size = new Size(115, 25);
        label3.TabIndex = 7;
        label3.Text = "Reservations:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(24, 66);
        label1.Name = "label1";
        label1.Size = new Size(93, 25);
        label1.TabIndex = 8;
        label1.Text = "Customer:";
        // 
        // cmbCustomer
        // 
        cmbCustomer.FormattingEnabled = true;
        cmbCustomer.Location = new Point(129, 58);
        cmbCustomer.Name = "cmbCustomer";
        cmbCustomer.Size = new Size(352, 33);
        cmbCustomer.TabIndex = 5;
        cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(323, 157);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(158, 37);
        btnUpdate.TabIndex = 11;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // FrmReservation
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1198, 501);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(dgvReservation);
        Controls.Add(dtpRes_Date);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(cmbCustomer);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmReservation";
        Text = "FrmReservation";
        Load += FrmReservation_Load;
        ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDelete;
    private DataGridView dgvReservation;
    private DateTimePicker dtpRes_Date;
    private Label label2;
    private Label label3;
    private Label label1;
    private ComboBox cmbCustomer;
    private Button btnUpdate;
}