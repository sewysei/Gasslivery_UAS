using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class HitungJarak
    {
        public static double HitungJarakKm(
        double lat1, double lon1,
        double lat2, double lon2)
        {
            const double R = 6371; // Radius bumi (km)

            double dLat = ToRad(lat2 - lat1);
            double dLon = ToRad(lon2 - lon1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRad(lat1)) * Math.Cos(ToRad(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // hasil dalam KM
        }

        private static double ToRad(double value)
        {
            return value * Math.PI / 180;
        }
    }
}
