using System;

namespace VerificaGit
{
    class Biblioteca
    {
        private string nome;
        private string indirizzo;
        private string apertura;
        private string chiusura;
        List<Libro> listaLibri = new List<Libro>();


        public Biblioteca (string _nome, string _indirizzo, string _apertura, string _chiusura, List<Libro> _listaLibri)
        {
            this.nome = _nome;
            this.indirizzo = _indirizzo;
            this.apertura = _apertura;
            this.chiusura = _chiusura;
            this.listaLibri = _listaLibri;
        }

        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Apertura { get; set; }
        public string Chiusura { get; set; }
        public List<Libro> ListaLibri { get; set; }

        public void AddLibro(Libro libro)
        {
            listaLibri.Add(libro);
        }

        public int FindByTitle(string titolo)
        {
            for (int i = 0; i < listaLibri.Count; i++)
            {
                if(titolo == listaLibri[i].Titolo) return i;
            }

            return -1;
        }

        public string FindByAuthor(string autore)
        {
            string libri = "";
            for(int i = 0;i < listaLibri.Count; i++)
            {
                if(autore == listaLibri[i].Autore)
                {
                    libri += " - " + listaLibri[i].Titolo + " - ";
                }
            }
            return libri;
        }

        public int Count() => listaLibri.Count;

    }
}