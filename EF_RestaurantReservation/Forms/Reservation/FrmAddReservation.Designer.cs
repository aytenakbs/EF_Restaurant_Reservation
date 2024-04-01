namespace EF_RestaurantReservation.Forms.Reservation;

partial class FrmAddReservation
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
        cmbCustomer = new ComboBox();
        label1 = new Label();
        dtpRes_Date = new DateTimePicker();
        dgvReservation = new DataGridView();
        label2 = new Label();
        label3 = new Label();
        btnAdd = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
        SuspendLayout();
        // 
        // cmbCustomer
        // 
        cmbCustomer.FormattingEnabled = true;
        cmbCustomer.Location = new Point(133, 58);
        cmbCustomer.Name = "cmbCustomer";
        cmbCustomer.Size = new Size(267, 33);
        cmbCustomer.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 66);
        label1.Name = "label1";
        label1.Size = new Size(93, 25);
        label1.TabIndex = 1;
        label1.Text = "Customer:";
        // 
        // dtpRes_Date
        // 
        dtpRes_Date.Location = new Point(133, 106);
        dtpRes_Date.Name = "dtpRes_Date";
        dtpRes_Date.Size = new Size(267, 31);
        dtpRes_Date.TabIndex = 2;
        // 
        // dgvReservation
        // 
        dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvReservation.Location = new Point(426, 58);
        dgvReservation.Name = "dgvReservation";
        dgvReservation.RowHeadersWidth = 51;
        dgvReservation.Size = new Size(671, 409);
        dgvReservation.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 112);
        label2.Name = "label2";
        label2.Size = new Size(53, 25);
        label2.TabIndex = 1;
        label2.Text = "Date:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(426, 19);
        label3.Name = "label3";
        label3.Size = new Size(115, 25);
        label3.TabIndex = 1;
        label3.Text = "Reservations:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(254, 159);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(146, 37);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // FrmAddReservation
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1119, 479);
        Controls.Add(btnAdd);
        Controls.Add(dgvReservation);
        Controls.Add(dtpRes_Date);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(cmbCustomer);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmAddReservation";
        Text = "FrmAddReservation";
        Load += FrmAddReservation_Load;
        ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbCustomer;
    private Label label1;
    private DateTimePicker dtpRes_Date;
    private DataGridView dgvReservation;
    private Label label2;
    private Label label3;
    private Button btnAdd;
}