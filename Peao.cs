using System;

public class Peao : Peça{
    public Peao(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimento()
    {
        return true: //logica de movimentação do peão
    }
}

PictureBox torre = new PictureBox();
peao.Location = new Point(50,50);
peao.Size = new Size(50,50);
peao.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "peao.png");
  MessageBox.Show("Tentando carregar: " + path);
  peao.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(peao);
{

   #endregion
   }

