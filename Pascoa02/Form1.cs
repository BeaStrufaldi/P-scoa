using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pascoa02
{
    public partial class Form1 : Form
    {
        List<Pessoas> lst = new List<Pessoas>();
        List<Pessoas> lstSorteados = new List<Pessoas>();
        List<Pessoas> lstSorteantes = new List<Pessoas>();
        int a;
        Random rdn = new Random();

        Pessoas p = new Pessoas();

        public Form1()
        {
            InitializeComponent();
            btnSortear.Enabled = false;
            btnApagar.Enabled = false;
        }

        private void btnAdicionar_Clicked(object sender, EventArgs e)
        {
            if(txtNome.Text != String.Empty && txtNome.Text.Length > 0)
            {
            string a = txtNome.Text;
            string b = txtChocolate.Text;
            Pessoas p = new Pessoas();
            p.name = a;
            p.chocolate = b;
            lst.Add(p);
            lstNomes.Items.Add(p.name);
            txtNome.Text = string.Empty;
            txtChocolate.Text = string.Empty;
            }

        }

        private void btnApagar_Clicked(object sender, EventArgs e)
        {
            if (lstNomes.SelectedItem != null)
            {
                Pessoas pessoa = lst.Find(p => p.name == lstNomes.SelectedItem.ToString());
                lst.Remove(pessoa);
                //lstNomes.Items.Clear();
                // this.lst[a].name.Items.Remove(this.lst[a].names.SelectedItem); 
                //lst.Remove()


                this.lstNomes.Items.Remove(this.lstNomes.SelectedItem);
                // lstSorteados.Remove(lstNomes.SelectedItem());

            }
        }

        private void lstNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNomes.SelectedItem != null)
            {
                btnSortear.Enabled = true;
                btnApagar.Enabled = true;
            }
            else
            {
                btnSortear.Enabled = false;
                btnApagar.Enabled = false;
            }
        }

        private void btnSortear_Clicked(object sender, EventArgs e)
        {
            #region
            //Random i = new Random();
            //int a = i.Next(0, lst.Count);

            //if ((lstSorteados.Contains(lst[a].name)))
            //{
            //    int b = i.Next(0, lst.Count);
            //    while (a == b)
            //    {
            //        b = i.Next(0, lst.Count);
            //    }
            //    ContidoSorteados(b);
            //}
            //else
            //{
            //    ContidoSorteados(a);

            //else
            //{
            //    MessageBox.Show("Faz Mais uma vez");
            //    //Environment.Exit(0);
            //}

            //}
            #endregion
            a = Gerar_Numero();
            if (lstSorteados.Contains(lst[a]) || lst[a].name == lstNomes.SelectedItem.ToString())
            {
                btnSortear_Clicked(sender, e);
            }
            else
            {
                if (lst.Count == 2)
                {
                    
                    //p.name = lstNomes.SelectedItem.ToString();
                    int dex = lstNomes.SelectedIndex;
                    if (dex == 1)
                    {
                        lstNomes.SetSelected(0,true);
                        p.name = lstNomes.SelectedItem.ToString();
                        lstNomes.SetSelected(dex, true);
                    }
                    else
                    {
                        lstNomes.SetSelected(1, true);
                        p.name = lstNomes.SelectedItem.ToString();
                        lstNomes.SetSelected(dex, true);
                    }
                    
                    if (lstSorteados.Contains(p) || p.name==lst[a].name)
                    {
                        gravar();
                    }
                    else
                    {   
                        btnSortear_Clicked(sender, e);
                    }
                }
                else
                {
                    gravar();
                }
            }

        }

        private void ContidoSorteados(int a)
        {
            //while (!(lstSorteados.Contains(lst[a].name)))
            //{
            //    if (lstNomes.SelectedItem != null)
            //    {
            //        if (lst[a].name != lstNomes.SelectedItem.ToString())
            //        {
            //            MessageBox.Show("Nome: " + lst[a].name + " Chocolate: " + lst[a].chocolate);
            //            lstSorteados.Add(lst[a].name);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Faz denovo");
            //            break;
            //            //Environment.Exit(0);
            //        }

            //    }
            //}
        }

        private int Gerar_Numero()
        {
            int a = rdn.Next(0, (lst.Count));
            return a;
        }

        private void gravar()
        {
            p.name = lstNomes.SelectedItem.ToString();
            MessageBox.Show("Nome: " + lst[a].name + " Chocolate: " + lst[a].chocolate);
            lstSorteados.Add(lst[a]);
            lstNomes.Items.Remove(lstNomes.SelectedItem);
            lstNomes.ClearSelected();
            lst.RemoveAt(a);
        }

        private void Count2(object sender, EventArgs e,Pessoas p)
        {
            if (a == 1)
            {
                if (lstSorteados.Contains(lst[0]) || lstSorteados.Contains(p))
                {
                    gravar();
                }
                else
                {
                    btnSortear_Clicked(sender, e);
                }
            }
            else
            {
                if (a == 0)
                {
                    if (!lstSorteados.Contains(lst[1]) || lstSorteados.Contains(p))
                    {
                        gravar();
                    }
                    else
                    {
                        btnSortear_Clicked(sender, e);
                    }
                }
            }
        }
    }
}
    
