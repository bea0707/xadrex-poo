public class Rei : Peca
{
    public Rei(string cor, int x, int y) : base (cor, x, y){}


    public override bool VerificarMovimento()
    {
       if (){
            return true;
        }
        else{
            Console.WriteLine("Este movimento para o Rei é inválido.");
        }
     }
}

PictureBox rei = new PictureBox();
rei.Location = new Point(50,50);
rei.Size = new Size(50,50);
rei.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "rei.png");
  MessageBox.Show("Tentando carregar: " + path);
  rei.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(rei);
{

   #endregion
   }

