public class Bispo : Peca
{
    public Bispo(string cor, int x, int y) : base (cor, x, y){}


    public override bool VerificarMovimento()
    {
       if (){
            return true;
        }
        else{
            Console.WriteLine("Este movimento para o bispo é inválido.");
        }
       
       
    }
}

PictureBox bispo = new PictureBox();
bispo.Location = new Point(50,50);
bispo.Size = new Size(50,50);
bispo.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "bispo.png");
  MessageBox.Show("Tentando carregar: " + path);
  bispo.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(bispo);
{

   #endregion
   }

