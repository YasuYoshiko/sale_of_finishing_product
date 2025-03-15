using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_finishing_product.Models
{
    internal class DBSupabase
    {
        async public void Db()
        {
            var url = Environment.GetEnvironmentVariable("https://txqyqdxbuwnrmbepyjgt.supabase.co");
            var key = Environment.GetEnvironmentVariable("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InR4cXlxZHhidXducm1iZXB5amd0Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDE5NDI5OTEsImV4cCI6MjA1NzUxODk5MX0.eDh33XK4L890utkKJ5yg_NVrMLs15HnMoNHwZiRLyU0");

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }
    }
}
