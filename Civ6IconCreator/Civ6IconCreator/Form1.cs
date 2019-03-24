using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace Civ6IconCreator
{
    public partial class Form1 : Form
    {
        //Form内共通変数、定数
        string outputDirName;
        string inputFilePath;
        string texConvPath;
        string sedPath;

        int[] sizesLeaders       = new int[] {256, 80,64,55,50,45,32};
        int[] sizesCivilizations = new int[] {256, 80,64,50,48,45,44,36,30,22};
        int[] sizesUnitFlags     = new int[] {256, 80,50,38,32,22};
        int[] sizesUnitPortraits = new int[] {256,200,95,70,50,38};
        int[] sizesBuildings     = new int[] {256,128,80,50,38,32};
        int[] sizesDistricts     = new int[] {256,128,80,50,38,32,22};
        int[] sizesImprovements  = new int[] {256, 80,50,38};

        //コンストラクタ
        public Form1()
        {
            InitializeComponent();

            //前回の指定箇所を復元
            //入力ファイル
            if (System.IO.File.Exists(Properties.Settings.Default.inputFile))
            {
                inputFilePath = Properties.Settings.Default.inputFile;
                inputTextBox.Text = inputFilePath;
                inputFileDialog.FileName = Path.GetFileName(inputFilePath);
                inputFileDialog.InitialDirectory = Path.GetDirectoryName(inputFilePath);

                //プレビューする
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.BackgroundImage = Properties.Resources.bg;
                pictureBox1.Image = System.Drawing.Image.FromFile(inputFilePath);
            }
            else
            {
                //消されていたらデフォルト値にする
                inputFilePath = "";
                inputTextBox.Text = "";
                inputFileDialog.FileName = "";
                inputFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            }
            //出力先ディレクトリ
            if (System.IO.Directory.Exists(Properties.Settings.Default.outputDirName))
            {
                outputDirName = Properties.Settings.Default.outputDirName;
                outputTextBox.Text = outputDirName;
                outputDirDialog.SelectedPath = outputDirName;
            }
            else
            {
                //消されていたらデフォルト値にする
                outputDirName = "";
                outputTextBox.Text = "";
                outputDirDialog.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            }
            //DirectX10互換モード
            checkBoxDirectX10.Checked = Properties.Settings.Default.checkedDX10;

            //GPU使用有無
            checkBoxNoGPU.Checked = Properties.Settings.Default.checkedNoGPU;

            //外部アプリケーションは直下にあるものとして設定する
            texConvPath = System.Windows.Forms.Application.StartupPath + @"\texconv.exe";
            sedPath = System.Windows.Forms.Application.StartupPath + @"\onigsed.exe";

            if (inputTextBox.Text != "" && outputTextBox.Text != "")
            {
                generateButton.Enabled = true;
            }
#if DEBUG
            File.WriteAllText("debug.log", "---- Application Start. ----\r\n");
#endif
        }

        //========================================
        // イベント
        //========================================
        //====================
        // メイン
        //====================
        //Inputの開くボタンが押されたとき
        private void inputButton_Click(object sender, EventArgs e)
        {
            //Inputの画像を開くボタン
            if (DialogResult.OK == inputFileDialog.ShowDialog())
            {
                //サイズチェック
                FileStream fs = new FileStream(inputFileDialog.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                int imagew = System.Drawing.Image.FromStream(fs).Width;
                int imageh = System.Drawing.Image.FromStream(fs).Height;
                fs.Close();
#if DEBUG
                File.AppendAllText("debug.log","幅："+imagew+ " 高さ：" + imageh + "\r\n");
#endif
                if (imagew != 256 || imageh != 256)
                {
                    MessageBox.Show(
                        this,"画像のサイズが256x256ではありません。","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                inputFilePath = inputFileDialog.FileName;
                inputTextBox.Text = inputFilePath;

                //previewする
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.BackgroundImage = Properties.Resources.bg;
                pictureBox1.Image = System.Drawing.Image.FromFile(inputFilePath);

                if(outputTextBox.Text != "" && System.IO.Directory.Exists(outputDirName))
                {
                    generateButton.Enabled = true;
                }

                //覚える
                Properties.Settings.Default.inputFile = inputFilePath;
                Properties.Settings.Default.Save();
            }
        }

        //Outputの開くボタンが押されたとき
        private void outputButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == outputDirDialog.ShowDialog())
            {
                outputDirName = outputDirDialog.SelectedPath;
                outputTextBox.Text = outputDirName;

                if (inputTextBox.Text != "" && System.IO.File.Exists(inputFilePath))
                {
                    generateButton.Enabled = true;
                }

                //覚える
                Properties.Settings.Default.outputDirName = outputDirName;
                Properties.Settings.Default.Save();
            }
        }

        //生成ボタンが押されたとき
        private void generateButton_Click(object sender, EventArgs e)
        {
            //チェックされてるものに合わせてDDS変換とTex生成を実施する
            if (radioButton1.Checked) {
                _generateDDS(sizesLeaders);
                _generateTex("Leaders", sizesLeaders);
                toolStripStatusLabel1.Text = "変換完了(Leaders)";
            }
            if (radioButton2.Checked) {
                _generateDDS(sizesCivilizations);
                _generateTex("Civilizations", sizesCivilizations);
                toolStripStatusLabel1.Text = "変換完了(Civilizations)";
            }
            if (radioButton3.Checked) {
                _generateDDS(sizesUnitFlags);
                _generateTex("UnitFlags", sizesUnitFlags);
                toolStripStatusLabel1.Text = "変換完了(UnitFlags)";
            }
            if (radioButton4.Checked) {
                _generateDDS(sizesUnitPortraits);
                _generateTex("UnitPortraits", sizesUnitPortraits);
                toolStripStatusLabel1.Text = "変換完了(UnitPortraits)";
            }
            if (radioButton5.Checked) {
                _generateDDS(sizesBuildings);
                _generateTex("Buildings", sizesBuildings);
                toolStripStatusLabel1.Text = "変換完了(Buildings)";
            }
            if (radioButton6.Checked) {
                _generateDDS(sizesDistricts);
                _generateTex("Districts", sizesDistricts);
                toolStripStatusLabel1.Text = "変換完了(Districts)";
            }
            if (radioButton7.Checked) {
                _generateDDS(sizesImprovements);
                _generateTex("Improvements", sizesImprovements);
                toolStripStatusLabel1.Text = "変換完了(Improvements)";
            };
        }

        //====================
        // オプション
        //====================
        //記憶場所消去のボタンが押されたとき
        private void ResetButton_Click(object sender, EventArgs e)
        {
            inputFilePath = "";
            outputDirName = "";
            inputTextBox.Text = "";
            outputTextBox.Text = "";
            Properties.Settings.Default.inputFile = "";
            Properties.Settings.Default.outputDirName = "";
            Properties.Settings.Default.Save();

            toolStripStatusLabel1.Text = "ディレクトリの記憶情報を消去しました。";
        }

        //DirectX互換モードのチェックが変わったとき
        private void checkBoxDirectX10_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkedDX10 = checkBoxDirectX10.Checked;
            Properties.Settings.Default.Save();
        }

        //GPUを使用しないのチェックが変わったとき
        private void checkBoxNoGPU_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkedNoGPU = checkBoxNoGPU.Checked;
            Properties.Settings.Default.Save();
        }

        //========================================
        // 内部関数
        //========================================
        //DDS変換関数(texconvに丸投げ)
        private void _generateDDS(int[] sizes)
        {
            string optDx10 = "";
            string optNoGPU = "";

            //DirectX10互換モードの有無
            if (checkBoxDirectX10.Checked)
            {
                optDx10 = "-dx10 ";
            }
            //GPU使用の有無
            if (checkBoxNoGPU.Checked)
            {
                optNoGPU = "-nogpu ";
            }

            foreach (int imgSize in sizes)
            {
                //PNGからDDSに変換
                var app = new ProcessStartInfo
                {
                    FileName = texConvPath,
                    Arguments = " -y -f R8G8B8A8_UNORM " + optDx10 + optNoGPU + "-if BOX -w " + imgSize + " -h " + imgSize + " -m 1 -sx " + imgSize + " -o \"" + outputDirName + "\" \"" + inputFilePath + "\"",
                    WorkingDirectory = System.IO.Path.GetDirectoryName(texConvPath),
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                };
#if DEBUG
                File.AppendAllText("debug.log", app.FileName  + @" " + app.Arguments + "\r\n");

                Process p = Process.Start(app);
                string output = p.StandardOutput.ReadToEnd(); // 標準出力の読み取り
                output = output.Replace("\r\r\n", "\n"); // 改行コードの修正

                File.AppendAllText("debug.log", output);
#else
                Process.Start(app);
#endif
            }
        }

        //tex生成関数(正確にはベースをコピーして置換してるだけ)
        private void _generateTex(string type, int[] sizes)
        {
            //拡張子を除いた入力ファイル名を取得
            string bfInputFileName = System.IO.Path.GetFileNameWithoutExtension(inputFilePath);
            //サイズと拡張子を除いたテンプレートのファイル名を取得
            string templateDir = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName + @"\template\tex\" + type;
            string bfTemplateName = templateDir +@"\"+ type +"Template";

            foreach (int imgSize in sizes)
            {
                //出力先ファイルパスを作成
                string outputPath = outputDirName + @"\" + bfInputFileName + imgSize + ".tex";

                //テンプレートのファイルから置換後のファイルを生成
                var app = new ProcessStartInfo();
                app.FileName = sedPath;
                app.Arguments = " -e s/" + type + "Template/" + bfInputFileName + "/g \"" + bfTemplateName + imgSize + ".tex\"";
                app.WorkingDirectory = System.IO.Path.GetDirectoryName(sedPath);
                app.CreateNoWindow = true;
                app.RedirectStandardOutput = true;
                app.UseShellExecute = false;
                Process p = Process.Start(app);
#if DEBUG
                File.AppendAllText("debug.log", app.FileName + @" " + app.Arguments + "\r\n");
#endif
                string output = p.StandardOutput.ReadToEnd(); // 標準出力の読み取り
#if DEBUG
                File.AppendAllText("debug.log", "========================================\r\n");
                File.AppendAllText("debug.log", output+"\r\n");
#endif
                File.WriteAllText(outputPath, output);
            }
        }
    }
}
