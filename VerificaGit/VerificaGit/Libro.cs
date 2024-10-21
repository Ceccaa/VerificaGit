using System;

namespace VerificaGit
{
    class Libro
    {
        private string autore;
        private string titolo;
        private string pubblicazione;
        private string editore;
        private int pagine;

        public Libro(string _autore, string _titolo, string _pubblicazione, string _editore, int _pagine)
        {
            this.autore = _autore;
            this.titolo = _titolo;
            this.pubblicazione = _pubblicazione;
            this.editore = _editore;
            this.pagine = _pagine;
        }

        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string Pubblicazione { get; set; }
        public string Editore { get; set; }
        public int Pagine { get; set; }


        public override string ToString() => (autore + " - " + titolo + " - " + pubblicazione + " - " + editore + " - " + pagine);

        public string ReadingTime()
        {
            if(pagine < 100)
            {
                return "1h";
            } else if(pagine > 100 && pagine < 200)
            {
                return "2h";
            }
            else
            {
                return "+2h";
            }
        }

    }

}