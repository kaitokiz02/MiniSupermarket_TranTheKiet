namespace MiniSupermarket.WinForms
{
    partial class FormRoleManagement
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvRoles;

        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxInfo;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.dgvRoles = new System.Windows.Forms.DataGridView();

            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();

            this.lblId = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();

            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.Id =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.RoleName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.Description =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvRoles)).BeginInit();

            this.groupBoxList.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(850, 500);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý Vai trò";

            this.Name =
                "FormRoleManagement";

            this.Load +=
                new System.EventHandler(
                    this.FormRoleManagement_Load);

            // =====================================================
            // GROUPBOX DANH SÁCH
            // =====================================================

            this.groupBoxList.Location =
                new System.Drawing.Point(10, 10);

            this.groupBoxList.Name =
                "groupBoxList";

            this.groupBoxList.Size =
                new System.Drawing.Size(520, 460);

            this.groupBoxList.TabIndex =
                0;

            this.groupBoxList.TabStop =
                false;

            this.groupBoxList.Text =
                "Danh sách Vai trò";

            this.groupBoxList.Controls.Add(
                this.dgvRoles);

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            this.dgvRoles.AllowUserToAddRows =
                false;

            this.dgvRoles.AllowUserToDeleteRows =
                false;

            this.dgvRoles.AllowUserToResizeRows =
                false;

            this.dgvRoles.AutoGenerateColumns =
                false;

            this.dgvRoles.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvRoles.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvRoles.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvRoles.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.Id,
                    this.RoleName,
                    this.Description
                });

            this.dgvRoles.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvRoles.Location =
                new System.Drawing.Point(3, 19);

            this.dgvRoles.MultiSelect =
                false;

            this.dgvRoles.Name =
                "dgvRoles";

            this.dgvRoles.ReadOnly =
                true;

            this.dgvRoles.RowHeadersWidth =
                40;

            this.dgvRoles.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvRoles.Size =
                new System.Drawing.Size(514, 438);

            this.dgvRoles.TabIndex =
                0;

            this.dgvRoles.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvRoles_CellClick);

            // =====================================================
            // CỘT ID
            // =====================================================

            this.Id.DataPropertyName =
                "Id";

            this.Id.HeaderText =
                "Mã ID";

            this.Id.Name =
                "Id";

            this.Id.ReadOnly =
                true;

            this.Id.Width =
                60;

            // =====================================================
            // CỘT ROLE NAME
            // =====================================================

            this.RoleName.DataPropertyName =
                "RoleName";

            this.RoleName.HeaderText =
                "Tên vai trò";

            this.RoleName.Name =
                "RoleName";

            this.RoleName.ReadOnly =
                true;

            this.RoleName.Width =
                150;

            // =====================================================
            // CỘT DESCRIPTION
            // =====================================================

            this.Description.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.Description.DataPropertyName =
                "Description";

            this.Description.HeaderText =
                "Mô tả";

            this.Description.Name =
                "Description";

            this.Description.ReadOnly =
                true;

            // =====================================================
            // GROUPBOX THÔNG TIN
            // =====================================================

            this.groupBoxInfo.Location =
                new System.Drawing.Point(545, 10);

            this.groupBoxInfo.Name =
                "groupBoxInfo";

            this.groupBoxInfo.Size =
                new System.Drawing.Size(295, 460);

            this.groupBoxInfo.TabIndex =
                1;

            this.groupBoxInfo.TabStop =
                false;

            this.groupBoxInfo.Text =
                "Thông tin Vai trò";

            this.groupBoxInfo.Controls.Add(
                this.lblId);

            this.groupBoxInfo.Controls.Add(
                this.txtId);

            this.groupBoxInfo.Controls.Add(
                this.lblRoleName);

            this.groupBoxInfo.Controls.Add(
                this.txtRoleName);

            this.groupBoxInfo.Controls.Add(
                this.lblDescription);

            this.groupBoxInfo.Controls.Add(
                this.txtDescription);

            this.groupBoxInfo.Controls.Add(
                this.btnAdd);

            this.groupBoxInfo.Controls.Add(
                this.btnUpdate);

            this.groupBoxInfo.Controls.Add(
                this.btnDelete);

            // =====================================================
            // LABEL ID
            // =====================================================

            this.lblId.AutoSize =
                true;

            this.lblId.Location =
                new System.Drawing.Point(15, 35);

            this.lblId.Name =
                "lblId";

            this.lblId.Size =
                new System.Drawing.Size(36, 15);

            this.lblId.Text =
                "Mã ID";

            // =====================================================
            // TEXTBOX ID
            // =====================================================

            this.txtId.Location =
                new System.Drawing.Point(15, 55);

            this.txtId.Name =
                "txtId";

            this.txtId.ReadOnly =
                true;

            this.txtId.Size =
                new System.Drawing.Size(260, 23);

            this.txtId.TabIndex =
                0;

            // =====================================================
            // LABEL ROLE NAME
            // =====================================================

            this.lblRoleName.AutoSize =
                true;

            this.lblRoleName.Location =
                new System.Drawing.Point(15, 95);

            this.lblRoleName.Name =
                "lblRoleName";

            this.lblRoleName.Size =
                new System.Drawing.Size(65, 15);

            this.lblRoleName.Text =
                "Tên vai trò";

            // =====================================================
            // TEXTBOX ROLE NAME
            // =====================================================

            this.txtRoleName.Location =
                new System.Drawing.Point(15, 115);

            this.txtRoleName.Name =
                "txtRoleName";

            this.txtRoleName.Size =
                new System.Drawing.Size(260, 23);

            this.txtRoleName.TabIndex =
                1;

            // =====================================================
            // LABEL DESCRIPTION
            // =====================================================

            this.lblDescription.AutoSize =
                true;

            this.lblDescription.Location =
                new System.Drawing.Point(15, 155);

            this.lblDescription.Name =
                "lblDescription";

            this.lblDescription.Size =
                new System.Drawing.Size(52, 15);

            this.lblDescription.Text =
                "Mô tả";

            // =====================================================
            // TEXTBOX DESCRIPTION
            // =====================================================

            this.txtDescription.Location =
                new System.Drawing.Point(15, 175);

            this.txtDescription.Multiline =
                true;

            this.txtDescription.Name =
                "txtDescription";

            // Không có thanh cuộn
            this.txtDescription.ScrollBars =
                System.Windows.Forms.ScrollBars.None;

            this.txtDescription.Size =
                new System.Drawing.Size(260, 80);

            this.txtDescription.TabIndex =
                2;

            // =====================================================
            // BUTTON THÊM
            // =====================================================

            this.btnAdd.Location =
                new System.Drawing.Point(15, 280);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(75, 30);

            this.btnAdd.TabIndex =
                3;

            this.btnAdd.Text =
                "Thêm mới";

            this.btnAdd.UseVisualStyleBackColor =
                true;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // =====================================================
            // BUTTON CẬP NHẬT
            // =====================================================

            this.btnUpdate.Location =
                new System.Drawing.Point(100, 280);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(75, 30);

            this.btnUpdate.TabIndex =
                4;

            this.btnUpdate.Text =
                "Cập nhật";

            this.btnUpdate.UseVisualStyleBackColor =
                true;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =====================================================
            // BUTTON XÓA
            // =====================================================

            this.btnDelete.Location =
                new System.Drawing.Point(185, 280);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(65, 30);

            this.btnDelete.TabIndex =
                5;

            this.btnDelete.Text =
                "Xóa";

            this.btnDelete.UseVisualStyleBackColor =
                true;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // =====================================================
            // ADD CONTROLS TO FORM
            // =====================================================

            this.Controls.Add(
                this.groupBoxInfo);

            this.Controls.Add(
                this.groupBoxList);

            // =====================================================
            // FINISH
            // =====================================================

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvRoles)).EndInit();

            this.groupBoxList.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion
    }
}