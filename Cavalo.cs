public class Cavalo : Peca
{
    public Cavalo(string cor, int x, int y) : base (cor, x, y){}


    public override bool VerificarMovimento()
    {
       if (){
            return true;
        }
        else{
            Console.WriteLine("Este movimento para o Cavalo é inválido.");
        }
       
       
    }
}

PictureBox cavalo = new PictureBox();
cavalo.Location = new Point(50,50);
cavalo.Size = new Size(50,50);
cavalo.SizeMode = PictureBoxSizeMode.StretchImage;

try
{
  string path = Path.Combine(Application.StartupPath, "imagens", "cavalo.png");
  MessageBox.Show("Tentando carregar: " + path);
  cavalo.Image = Image.From.File(path);
}

catch (Exception ex)

{

  MessageBox.Show("Erro ao carregar imagem: " + ex.Message);

}

   this.Controls.Add(cavalo);
{

   #endregion
   }

