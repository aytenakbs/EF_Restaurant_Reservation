namespace EF_RestaurantReservation.Forms.Customer;

partial class FrmCustomer
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
        dtGridCustomerList = new DataGridView();
        label2 = new Label();
        grpBoxSelectedCustomer = new GroupBox();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label1 = new Label();
        txtAddress = new TextBox();
        txtPhoneNumber = new TextBox();
        txtEmail = new TextBox();
        txtSurname = new TextBox();
        txtName = new TextBox();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dtGridCustomerList).BeginInit();
        grpBoxSelectedCustomer.SuspendLayout();
        SuspendLayout();
        // 
        // dtGridCustomerList
        // 
        dtGridCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridCustomerList.Location = new Point(459, 65);
        dtGridCustomerList.Margin = new Padding(4);
        dtGridCustomerList.Name = "dtGridCustomerList";
        dtGridCustomerList.RowHeadersWidth = 51;
        dtGridCustomerList.Size = new Size(724, 541);
        dtGridCustomerList.TabIndex = 0;
        dtGridCustomerList.CellClick += dtGridCustomerList_CellClick;
        dtGridCustomerList.CellContentClick += dtGridCustomerList_CellContentClick;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(459, 19);
        label2.Name = "label2";
        label2.Size = new Size(113, 25);
        label2.TabIndex = 3;
        label2.Text = "CUSTOMERS";
        // 
        // grpBoxSelectedCustomer
        // 
        grpBoxSelectedCustomer.Controls.Add(label6);
        grpBoxSelectedCustomer.Controls.Add(label5);
        grpBoxSelectedCustomer.Controls.Add(label4);
        grpBoxSelectedCustomer.Controls.Add(label3);
        grpBoxSelectedCustomer.Controls.Add(label1);
        grpBoxSelectedCustomer.Controls.Add(txtAddress);
        grpBoxSelectedCustomer.Controls.Add(txtPhoneNumber);
        grpBoxSelectedCustomer.Controls.Add(txtEmail);
        grpBoxSelectedCustomer.Controls.Add(txtSurname);
        grpBoxSelectedCustomer.Controls.Add(txtName);
        grpBoxSelectedCustomer.Controls.Add(btnDelete);
        grpBoxSelectedCustomer.Controls.Add(btnUpdate);
        grpBoxSelectedCustomer.Location = new Point(12, 19);
        grpBoxSelectedCustomer.Name = "grpBoxSelectedCustomer";
        grpBoxSelectedCustomer.Size = new Size(440, 409);
        grpBoxSelectedCustomer.TabIndex = 4;
        grpBoxSelectedCustomer.TabStop = false;
        grpBoxSelectedCustomer.Text = "Selected Customer";
        grpBoxSelectedCustomer.Enter += grpBoxSelectedCustomer_Enter;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(9, 262);
        label6.Name = "label6";
        label6.Size = new Size(81, 25);
        label6.TabIndex = 11;
        label6.Text = "Address:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(9, 217);
        label5.Name = "label5";
        label5.Size = new Size(136, 25);
        label5.TabIndex = 12;
        label5.Text = "Phone Number:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(9, 164);
        label4.Name = "label4";
        label4.Size = new Size(58, 25);
        label4.TabIndex = 13;
        label4.Text = "Email:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(9, 111);
        label3.Name = "label3";
        label3.Size = new Size(86, 25);
        label3.TabIndex = 14;
        label3.Text = "Surname:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(9, 60);
        label1.Name = "label1";
        label1.Size = new Size(63, 25);
        label1.TabIndex = 15;
        label1.Text = "Name:";
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(167, 256);
        txtAddress.Margin = new Padding(4);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(244, 31);
        txtAddress.TabIndex = 6;
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(167, 211);
        txtPhoneNumber.Margin = new Padding(4);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.Size = new Size(244, 31);
        txtPhoneNumber.TabIndex = 7;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(167, 158);
        txtEmail.Margin = new Padding(4);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(244, 31);
        txtEmail.TabIndex = 8;
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(167, 105);
        txtSurname.Margin = new Padding(4);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(244, 31);
        txtSurname.TabIndex = 9;
        // 
        // txtName
        // 
        txtName.Location = new Point(167, 54);
        txtName.Margin = new Padding(4);
        txtName.Name = "txtName";
        txtName.Size = new Size(244, 31);
        txtName.TabIndex = 10;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(9, 326);
        btnDelete.Margin = new Padding(4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(150, 50);
        btnDelete.TabIndex = 4;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(228, 326);
        btnUpdate.Margin = new Padding(4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(155, 50);
        btnUpdate.TabIndex = 5;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // FrmCustomer
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1196, 619);
        Controls.Add(grpBoxSelectedCustomer);
        Controls.Add(label2);
        Controls.Add(dtGridCustomerList);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmCustomer";
        Text = "FrmCustomer";
        Load += FrmCustomer_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridCustomerList).EndInit();
        grpBoxSelectedCustomer.ResumeLayout(false);
        grpBoxSelectedCustomer.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dtGridCustomerList;
    private Label label2;
    private GroupBox grpBoxSelectedCustomer;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label1;
    private TextBox txtAddress;
    private TextBox txtPhoneNumber;
    private TextBox txtEmail;
    private TextBox txtSurname;
    private TextBox txtName;
    private Button btnDelete;
    private Button btnUpdate;
}