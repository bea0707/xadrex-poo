public class Torre : Peca
{
    public Torre(string cor, int x, int y) : base (cor, x, y){}


   public override bool VerificarMovimento()
    {
       if(){
         return true;
      }
    }
}

PictureBox torre = new PictureBox();
torre.Location = new Point(50,50);
torre.Size = new Size(50,50);
torre.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "torre.png");
  MessageBox.Show("Tentando carregar: " + path);
  torre.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(torre);
{

   #endregion
   }

