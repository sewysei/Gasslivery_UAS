using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public static class RideCalculator
    {
        // Menentukan harga per KM berdasarkan waktu jemput
        public static int GetHargaPerKm(DateTime waktu)
        {
            TimeSpan jam = waktu.TimeOfDay;

            // Jam sibuk pagi 06.00 - 08.00
            if (jam >= new TimeSpan(6, 0, 0) && jam <= new TimeSpan(8, 0, 0))
                return 2000;

            // Jam sibuk sore 16.00 - 18.00
            if (jam >= new TimeSpan(16, 0, 0) && jam <= new TimeSpan(18, 0, 0))
                return 2000;

            // Selain itu
            return 1000;
        }

        // Hitung total ongkos perjalanan
        public static int HitungTotal(
            double jarakKm,
            DateTime waktuJemput,
            bool requestDriverWanita,
            bool requestMotorBaru
        )
        {
            int tarifPerKm = GetHargaPerKm(waktuJemput);
            int total = (int)(jarakKm * tarifPerKm);

            if (requestDriverWanita)
                total += 1500;

            if (requestMotorBaru)
                total += 5000;

            return total;
        }
    }
}
