using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace JsonCreationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GestureList = new Dictionary<string, string>();
            EffectList = new Dictionary<string, string>();
            ColorList = new Dictionary<string, Color>();

        }

        private Dictionary<string, string> GestureList;
        private Dictionary<string, string> EffectList;
        private Dictionary<string, Color> ColorList;

        private void btnGAdd_Click(object sender, EventArgs e)
        {
            // Gesture Add
            if (string.IsNullOrEmpty(tbGjp.Text) || string.IsNullOrEmpty(tbGen.Text))
                return;

            if (GestureList.ContainsKey(tbGjp.Text))
            {
                MessageBox.Show("同じ名前のジェスチャーは登録できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GestureList.Add(tbGjp.Text, tbGen.Text);
            cbG.Items.Clear();
            cbG.Items.AddRange(GestureList.Keys.ToArray());

        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEjp.Text) || string.IsNullOrEmpty(tbEen.Text))
                return;

            if (EffectList.ContainsKey(tbEjp.Text))
            {
                MessageBox.Show("同じ名前のエフェクトは登録できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EffectList.Add(tbEjp.Text, tbEen.Text);
            cbE.Items.Clear();
            cbE.Items.AddRange(EffectList.Keys.ToArray());
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCjp.Text) || string.IsNullOrEmpty(tbCr.Text)
                || string.IsNullOrEmpty(tbCg.Text) || string.IsNullOrEmpty(tbCb.Text)
                || string.IsNullOrEmpty(tbCa.Text))
                return;

            if (ColorList.ContainsKey(tbCjp.Text))
            {
                MessageBox.Show("同じ名前の色は登録できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var col = new Color();
            col.r = int.Parse(tbCr.Text) / 255.0f;
            col.g = int.Parse(tbCg.Text) / 255.0f;
            col.b = int.Parse(tbCb.Text) / 255.0f;
            col.a = int.Parse(tbCa.Text) / 255.0f;

            ColorList.Add(tbCjp.Text, col);
            cbC.Items.Clear();
            cbC.Items.AddRange(ColorList.Keys.ToArray());
        }

        private void btnGDel_Click(object sender, EventArgs e)
        {
            GestureList.Remove((string)cbG.SelectedItem);
            cbG.Items.Clear();
            cbG.Items.AddRange(GestureList.Keys.ToArray());
        }

        private void btnEDel_Click(object sender, EventArgs e)
        {
            EffectList.Remove((string)cbE.SelectedItem);
            cbE.Items.Clear();
            cbE.Items.AddRange(EffectList.Keys.ToArray());
        }

        private void btnCDel_Click(object sender, EventArgs e)
        {
            ColorList.Remove((string)cbC.SelectedItem);
            cbC.Items.Clear();
            cbC.Items.AddRange(ColorList.Keys.ToArray());
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.FileName = "options.json";
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.Filter = "JSONファイル(*.json)|*.json";
            sfd.Title = "名前をつけてJSONファイルを保存";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var _sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                {
                    _sw.Write(MakeJson());
                }
                MessageBox.Show("ファイルの書き込みが完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string MakeJson()
        {
            var seriG = new Serialization<string, string>();
            seriG.Set(GestureList);
            var jsonG = JsonConvert.SerializeObject(seriG);

            var seriE = new Serialization<string, string>();
            seriE.Set(EffectList);
            var jsonE = JsonConvert.SerializeObject(seriE);

            var seriC = new Serialization<string, Color>();
            seriC.Set(ColorList);
            var jsonC = JsonConvert.SerializeObject(seriC);

            var obj = new CustomOptions();
            obj.Gesture = jsonG;
            obj.Effect = jsonE;
            obj.Color = jsonC;

            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        private void btnShowJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MakeJson(), "JSON", MessageBoxButtons.OK);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = "options.json";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "JSONファイル(*.json)|*.json";
            ofd.Title = "JSONファイルを選択してください";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    // 存在しているのでロード
                    using (var _sr = new StreamReader(ofd.FileName, System.Text.Encoding.UTF8))
                    {
                        var json = _sr.ReadToEnd();
                        var obj = JsonConvert.DeserializeObject<CustomOptions>(json);

                        GestureList = JsonConvert.DeserializeObject<Serialization<string, string>>(obj.Gesture).GetDictionary();
                        EffectList = JsonConvert.DeserializeObject<Serialization<string, string>>(obj.Effect).GetDictionary();
                        ColorList = JsonConvert.DeserializeObject<Serialization<string, Color>>(obj.Color).GetDictionary();

                        cbG.Items.Clear();
                        cbG.Items.AddRange(GestureList.Keys.ToArray());
                        cbE.Items.Clear();
                        cbE.Items.AddRange(EffectList.Keys.ToArray());
                        cbC.Items.Clear();
                        cbC.Items.AddRange(ColorList.Keys.ToArray());

                    }
                    MessageBox.Show("ファイルの読み込みが完了しました。" + Environment.NewLine + $"読み込まれた件数 : G[{GestureList.Count}] E[{EffectList.Count}] C[{ColorList.Count}]", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("JSONファイルを読み込めませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
