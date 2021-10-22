
namespace CRUD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.joined = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.joinedDate = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbl = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Application";
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.Location = new System.Drawing.Point(99, 110);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(177, 29);
            this.empID.TabIndex = 1;
            this.empID.Text = "Emplpoyee ID";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(99, 159);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(206, 29);
            this.empName.TabIndex = 2;
            this.empName.Text = "Employee Name";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(99, 206);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(181, 29);
            this.city.TabIndex = 3;
            this.city.Text = "Employee City";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(99, 250);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(183, 29);
            this.age.TabIndex = 4;
            this.age.Text = "Employee Age";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.Location = new System.Drawing.Point(99, 298);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(57, 29);
            this.sex.TabIndex = 5;
            this.sex.Text = "Sex";
            // 
            // joined
            // 
            this.joined.AutoSize = true;
            this.joined.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joined.Location = new System.Drawing.Point(99, 340);
            this.joined.Name = "joined";
            this.joined.Size = new System.Drawing.Size(153, 29);
            this.joined.TabIndex = 6;
            this.joined.Text = "Joined Date";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(99, 381);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(101, 29);
            this.contact.TabIndex = 7;
            this.contact.Text = "Contact";
            // 
            // txtempID
            // 
            this.txtempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempID.Location = new System.Drawing.Point(338, 107);
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(372, 32);
            this.txtempID.TabIndex = 8;
            // 
            // txtempName
            // 
            this.txtempName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempName.Location = new System.Drawing.Point(338, 159);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(372, 32);
            this.txtempName.TabIndex = 9;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(338, 250);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(372, 32);
            this.txtage.TabIndex = 10;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(338, 378);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(372, 32);
            this.txtcontact.TabIndex = 11;
            // 
            // cmbcity
            // 
            this.cmbcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
            "Kandy",
            "Colombo",
            "Anuradhapura"});
            this.cmbcity.Location = new System.Drawing.Point(338, 209);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(372, 34);
            this.cmbcity.TabIndex = 12;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.male.Location = new System.Drawing.Point(395, 305);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(70, 24);
            this.male.TabIndex = 13;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.female.Location = new System.Drawing.Point(551, 303);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(91, 24);
            this.female.TabIndex = 14;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // joinedDate
            // 
            this.joinedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinedDate.Location = new System.Drawing.Point(338, 340);
            this.joinedDate.Name = "joinedDate";
            this.joinedDate.Size = new System.Drawing.Size(372, 32);
            this.joinedDate.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(184, 446);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 36);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbl
            // 
            this.tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl.Location = new System.Drawing.Point(95, 502);
            this.tbl.Name = "tbl";
            this.tbl.RowHeadersWidth = 51;
            this.tbl.RowTemplate.Height = 24;
            this.tbl.Size = new System.Drawing.Size(679, 153);
            this.tbl.TabIndex = 17;
            this.tbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_CellContentClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(409, 446);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(164, 36);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.Location = new System.Drawing.Point(630, 446);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(164, 36);
            this.dltBtn.TabIndex = 19;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(733, 103);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(99, 36);
            this.load.TabIndex = 20;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 667);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.joinedDate);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtempName);
            this.Controls.Add(this.txtempID);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.joined);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.city);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label joined;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.DateTimePicker joinedDate;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView tbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button load;
    }
}

