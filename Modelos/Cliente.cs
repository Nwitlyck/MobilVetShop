﻿namespace MovilApp.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Telefono { get; set; }
        public string? Contacto { get; set; }
        public string ContactoDetallado { get { return $"{Contacto +"-"} {Telefono}"; } }

    }
}
