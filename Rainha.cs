public class Rainha : Peca
{
    public Rainha (string cor, int x, int y) : base (cor, x, y){}


    public override bool VerificarMovimento()
    {
       if (){
            return true;
        }
        else{
            Console.WriteLine("Este movimento para a Rainha é inválido.");
        }
     }
}

PictureBox rainha = new PictureBox();
rainha.Location = new Point(50,50);
rainha.Size = new Size(50,50);
rainha.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "rainha.png");
  MessageBox.Show("Tentando carregar: " + path);
  rainha.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(rainha);
{

   #endregion
   }


