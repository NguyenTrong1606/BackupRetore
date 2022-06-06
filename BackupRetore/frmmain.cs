using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace frmmain
{
    public partial class frmmain : DevExpress.XtraEditors.XtraForm
    {
        private String tenDevice;
        int sttBanBK;
        public frmmain()
        {
            InitializeComponent();
        }




        private void frmmain_Load(object sender, EventArgs e)
        {
            
            this.databasesTableAdapter1.Connection.ConnectionString = Program.connString;
            this.databasesTableAdapter1.Fill(this.DS1.databases);



            this.SP_STT_BACKUPTableAdapter.Connection.ConnectionString = Program.connString;
            Program.databaseName = txtNameDB.Text;
            this.SP_STT_BACKUPTableAdapter.Fill(this.DS1.SP_STT_BACKUP, Program.databaseName);
            CheckDeviceExist();
        }




        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            LoadBackup();
            
        }

        private void LoadBackup()
        {
            Program.databaseName = txtNameDB.Text;
            this.SP_STT_BACKUPTableAdapter.Connection.ConnectionString = Program.connString;    
            this.SP_STT_BACKUPTableAdapter.Fill(this.DS1.SP_STT_BACKUP, Program.databaseName);
            CheckDeviceExist();
        }

        
        private void ShowCreateDevice()
        {
            btnSaoLuu.Enabled = btnPhucHoi.Enabled = cbThamSoPhucHoiTheoTG.Enabled = btn_XoaBK.Enabled = false;
            btnTaoDeviceSaoLuu.Enabled = btnThoat.Enabled = true;
            cbDelete.Checked = false;
        }

        private void HideCreateDevice()
        {
            btnSaoLuu.Enabled = btnThoat.Enabled = true;
            if(bdsSP_STT_BACKUP.Count == 0)
            {
                btnPhucHoi.Enabled = cbThamSoPhucHoiTheoTG.Enabled = btn_XoaBK.Enabled = false;
            }
            else
            {
                btnPhucHoi.Enabled = cbThamSoPhucHoiTheoTG.Enabled = btn_XoaBK.Enabled = true;
            }
            btnTaoDeviceSaoLuu.Enabled = false;
            cbDelete.Checked = false;
        }
        private void CheckDeviceExist()
        {
            String strTenDevice = "select  COUNT(name) from  sys.backup_devices WHERE name = N'DEVICE_"
               + txtNameDB.Text.Trim() + "'";

            Program.reader = Program.ExecSqlDataReader(strTenDevice);
            if (Program.reader == null) return;

            Program.reader.Read();
            //Nếu chưa có device, ẩn các button khác, chỉ hiện button device và button thoát
            
            if (Program.reader.GetInt32(0) > 0)
            {
                HideCreateDevice();
                tenDevice = "DEVICE_" + txtNameDB.Text.Trim();
            }
            //Nếu đã có device, hiện các button khác, ẩn button tạo device đi
            else ShowCreateDevice();
            Program.reader.Close();

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnTaoDeviceSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Directory.Exists(Program.defaultPath) == true)
            {
                TaoDevice();
            }
            else
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    Program.defaultPath = folderPath + "\\";
                    TaoDevice();
                }

            }
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            progress.Visible = true;
            
            String strBK;
            if (txtNameDB == null || tenDevice == null) return;
            strBK = "BACKUP DATABASE " + txtNameDB.Text.Trim() + " TO " + tenDevice;
            if (cbDelete.Checked == true)
                if (MessageBox.Show("Bạn có thực sự muốn xóa các bản sao lưu trước đó không?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ClearBackupInBackupSet();
                    strBK = strBK + " WITH INIT";
                }

                    

            int err = Program.ExecSqlNonQuery(strBK, Program.connString);
            for (int i = this.progress.Minimum; i <= this.progress.Maximum / 2; i++)
                progress.Value = i;
            if (err != 1)
            {
                
                MessageBox.Show("Lỗi Backup cơ sở dữ liệu" + txtNameDB);
                progress.Visible = false;
                return;
            }

            for (int i = this.progress.Maximum / 2; i <= this.progress.Maximum; i++)
                progress.Value = i;
            progress.Visible = false;
            MessageBox.Show("Backup cơ sở dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
            
            LoadBackup();

        }
        private void ClearBackupInBackupSet()
        {
            Program.databaseName = txtNameDB.Text;
            this.taBackupset.Connection.ConnectionString = Program.connString;
            this.taBackupset.Fill(this.DS1.backupset, Program.databaseName);
            int countBackup = bdsBackupset.Count;
            for (int index = 0; index < countBackup; index++)
            {
                string backup_set_id = ((DataRowView)bdsBackupset[index])["backup_set_id"].ToString();
                DeleteBackup(int.Parse(backup_set_id));
            }
        }

        private void txtNameDB_EditValueChanged(object sender, EventArgs e)
        {
            LoadBackup();
        }

        private void TaoDevice()
        {
            progress.Visible = true;
            for (int i = this.progress.Minimum; i <= this.progress.Maximum / 2; i++)
                progress.Value = i;
            // Lưu trên disk
            String strTaoDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + txtNameDB.Text.Trim() + "', " +
                "'" + Program.defaultPath + "DEVICE_" + txtNameDB.Text.Trim() + ".bak' ";

            int err = Program.ExecSqlNonQuery(strTaoDevice, Program.connString);
            if (err == 1)
            {
                for (int i = this.progress.Maximum / 2; i <= this.progress.Maximum; i++)
                    progress.Value = i;
                progress.Visible = false;
                // Show message diaglog create device successfull
                MessageBox.Show("Tạo device thành công!", "Thông báo", MessageBoxButtons.OK);
                
                HideCreateDevice();
            }
            else
            {
                
                MessageBox.Show("Tạo device Không thành công!", "Thông báo", MessageBoxButtons.OK);
                progress.Visible = false;
                ShowCreateDevice();
            }
        }

        private void cbThamSoPhucHoiTheoTG_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbThamSoPhucHoiTheoTG.Checked == true)
            {
                String BanBK_Max = "SELECT POSITION FROM msdb.dbo.backupset WHERE (database_name = '" + txtNameDB.Text.Trim()
                    + "' AND (type = 'D') AND (backup_set_id = (SELECT   MAX(backup_set_id) FROM msdb.dbo.backupset  WHERE   (database_name = '"
                    + txtNameDB.Text.Trim() + "') AND (type = 'D'))))";

                Program.ExecSqlDataReader(BanBK_Max);

                if (Program.reader.Read())
                {
                    txtPosition.Text = Program.reader.GetValue(0).ToString();
                    sttBanBK = int.Parse(txtPosition.Text);
                    bdsSP_STT_BACKUP.Position = bdsSP_STT_BACKUP.Find("position", sttBanBK);
                    Program.reader.Close();

                }
                else
                {
                    MessageBox.Show("Ko tìm đươc bản backup mới nhất!!", "Thông báo");
                    Program.reader.Close();
                }


                edDate.DateTime = DateTime.Now.Date;
                edTime.Time = DateTime.Now.AddMinutes(-10);

                pcDateTime.Visible = true;

            }
            else pcDateTime.Visible = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (this.bdsSP_STT_BACKUP.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            if (txtNameDB.Text.Trim() == "" || tenDevice == "") return;

            //Phục hồi về 1 bản backup có sẵn
            if(cbThamSoPhucHoiTheoTG.Checked == false)
            {
                sttBanBK = int.Parse(txtPosition.Text);
                String strRestore = "ALTER DATABASE " + txtNameDB.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    " USE tempdb RESTORE DATABASE " + txtNameDB.Text.Trim()
                    + " FROM   " + tenDevice + " WITH FILE =  " + sttBanBK + ", REPLACE "
                    + "ALTER DATABASE  " + txtNameDB.Text.Trim() + " SET MULTI_USER";

                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Program.databaseName + " về file " + sttBanBK + "?"
                  , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    progress.Visible = true;
                    for (int i = this.progress.Minimum; i <= this.progress.Maximum / 4; i++)
                        progress.Value = i;

                    int err = Program.ExecSqlNonQuery(strRestore, Program.connString);

                    if (err == 1)
                    {
                        progress.Visible = true;
                        for (int i = this.progress.Maximum / 4; i <= this.progress.Maximum; i++)
                            progress.Value = i;
                        progress.Visible = false;
                        MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else progress.Visible = false; return;
                }
                
            }
            else
            {
                progress.Visible = true;
                for (int i = progress.Minimum; i <= progress.Maximum / 4; i++) progress.Value = i;
                String BanBK_Max = "SELECT POSITION FROM msdb.dbo.backupset WHERE (database_name = '" + txtNameDB.Text.Trim()
                    + "' AND (type = 'D') AND (backup_set_id = (SELECT   MAX(backup_set_id) FROM msdb.dbo.backupset  WHERE   (database_name = '"
                    + txtNameDB.Text.Trim() + "') AND (type = 'D'))))";

                Program.ExecSqlDataReader(BanBK_Max);

                if (Program.reader.Read())
                {
                    txtPosition.Text = Program.reader.GetValue(0).ToString();
                    sttBanBK = int.Parse(txtPosition.Text);
                    bdsSP_STT_BACKUP.Position = bdsSP_STT_BACKUP.Find("position", sttBanBK);
                    Program.reader.Close();

                }
                else
                {
                    MessageBox.Show("Ko tìm đươc bản backup mới nhất!!", "Thông báo");
                    Program.reader.Close();
                    progress.Visible = false;
                }

                
                for (int i = progress.Maximum / 4; i <= progress.Maximum / 2; i++) progress.Value = i;


                DateTime ngaygioBK = (DateTime)((DataRowView)bdsSP_STT_BACKUP[bdsSP_STT_BACKUP.Position])["backup_start_date"];

                String StrRetoretAtTime = edDate.DateTime.Year + "-" + edDate.DateTime.Month + "-" + edDate.DateTime.Day + " "
                    + edTime.Time.Hour + ":" + edTime.Time.Minute + ":" + edTime.Time.Second;

                DateTime rtAtTime = DateTime.Now;
                try
                {
                    rtAtTime = DateTime.Parse(StrRetoretAtTime);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi convert ngày" + ex.Message, "", MessageBoxButtons.OK);
                    progress.Visible = false;
                }

                if(rtAtTime > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    progress.Visible = false;
                    return;
                }

                if(DateTime.Compare(rtAtTime,ngaygioBK) <= 0)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã chọn", "", MessageBoxButtons.OK);
                    progress.Visible = false;
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Program.databaseName + " về ngày " + rtAtTime + "?"
                   , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        // Restore về 1 thời điểm người dùng nhập
                        String strRestore = "ALTER DATABASE " + txtNameDB.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                               " BACKUP LOG " + Program.databaseName + " TO DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' WITH INIT, NORECOVERY; \n " +
                               " USE tempdb \n" +
                               " RESTORE DATABASE " + Program.databaseName + " FROM  DEVICE_" + Program.databaseName + " WITH FILE =" + sttBanBK + ", NORECOVERY; \n" +
                               " RESTORE DATABASE " + Program.databaseName + " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' " +
                               " WITH STOPAT= '" + rtAtTime + "' \n" +
                               " ALTER DATABASE  " + Program.databaseName + " SET MULTI_USER ";
                        //MessageBox.Show(strRestore);
                        int err = Program.ExecSqlNonQuery(strRestore, Program.connString);
                        if (err == 1)
                        {
                            
                            for (int i = this.progress.Maximum/2; i <= this.progress.Maximum; i++)
                                progress.Value = i;
                            progress.Visible = false;
                            MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                            cbThamSoPhucHoiTheoTG.Checked = false;
                        }
                        else progress.Visible = false; return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Restore:\n" + ex, "Xảy ra lỗi", MessageBoxButtons.OK);
                        cbThamSoPhucHoiTheoTG.Checked = false;
                    }
                }
                else
                {
                    progress.Visible = false;
                    cbThamSoPhucHoiTheoTG.Checked = false;
                }

            }

        }

        private void btn_XoaBK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int backupSetId = int.Parse(((DataRowView)bdsSP_STT_BACKUP.Current)["backup_set_id"].ToString());

            if (MessageBox.Show("Bạn có thực sự muốn xóa các bản sao lưu trước đó không?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            int resultExec = DeleteBackup(backupSetId);

            if(resultExec == 1)
            {
                MessageBox.Show("Xóa bản backup thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Xóa bản backup thất bại \nError: {resultExec} ", "Thông báo", MessageBoxButtons.OK);
            }
            LoadBackup();

        }

        private int DeleteBackup(int backupSetId)
        {
            taRestore_id.Connection.ConnectionString = Program.connString;
            taRestore_id.Fill(this.DS1.restore_id, backupSetId);
            string query = string.Format(Program.DELETE_BACKUP, backupSetId);

            int restoreCount = bdsRestore_id.Count;
            if (restoreCount > 0)
            {
                string queryDeleteRestoreHistory = "";
                for (int index = 0; index < restoreCount; index++)
                {
                    string restore_history_id = ((DataRowView)bdsRestore_id[index])["restore_history_id"].ToString();
                    queryDeleteRestoreHistory += string.Format(Program.DELETE_RESTORE_HISTORY, restore_history_id);
                }
                query = queryDeleteRestoreHistory + query;
            }

            return Program.ExecSqlNonQuery(query, Program.connString);
        }



    }
}