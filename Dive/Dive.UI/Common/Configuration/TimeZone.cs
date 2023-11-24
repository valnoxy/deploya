﻿using System.Collections.Generic;

namespace Dive.UI.Common.Configuration
{
    internal class TimeZone
    {
        private static readonly List<string> Timezones = new()
        {
            "Dateline Standard Time", // (UTC-12:00) International Date Line West
            "UTC-11", // (UTC-11:00) Coordinated Universal Time-11
            "Aleutian Standard Time", // (UTC-10:00) Aleutian Islands
            "Hawaiian Standard Time", // (UTC-10:00) Hawaii
            "Marquesas Standard Time", // (UTC-09:30) Marquesas Islands
            "Alaskan Standard Time", // (UTC-09:00) Alaska
            "UTC-09", // (UTC-09:00) Coordinated Universal Time-09
            "Pacific Standard Time (Mexico)", // (UTC-08:00) Baja California
            "UTC-08", // (UTC-08:00) Coordinated Universal Time-08
            "Pacific Standard Time", // (UTC-08:00) Pacific Time (US & Canada)
            "US Mountain Standard Time", // (UTC-07:00) Arizona
            "Mountain Standard Time (Mexico)", // (UTC-07:00) La Paz, Mazatlan
            "Mountain Standard Time", // (UTC-07:00) Mountain Time (US & Canada)
            "Yukon Standard Time", // (UTC-07:00) Yukon
            "Central America Standard Time", // (UTC-06:00) Central America
            "Central Standard Time", // (UTC-06:00) Central Time (US & Canada)
            "Easter Island Standard Time", // (UTC-06:00) Easter Island
            "Central Standard Time (Mexico)", // (UTC-06:00) Guadalajara, Mexico City, Monterrey
            "Canada Central Standard Time", // (UTC-06:00) Saskatchewan
            "SA Pacific Standard Time", // (UTC-05:00) Bogota, Lima, Quito, Rio Branco
            "Eastern Standard Time (Mexico)", // (UTC-05:00) Chetumal
            "Eastern Standard Time", // (UTC-05:00) Eastern Time (US & Canada)
            "Haiti Standard Time", // (UTC-05:00) Haiti
            "Cuba Standard Time", // (UTC-05:00) Havana
            "US Eastern Standard Time", // (UTC-05:00) Indiana (East)
            "Turks And Caicos Standard Time", // (UTC-05:00) Turks and Caicos
            "Paraguay Standard Time", // (UTC-04:00) Asuncion
            "Atlantic Standard Time", // (UTC-04:00) Atlantic Time (Canada)
            "Venezuela Standard Time", // (UTC-04:00) Caracas
            "Central Brazilian Standard Time", // (UTC-04:00) Cuiaba
            "SA Western Standard Time", // (UTC-04:00) Georgetown, La Paz, Manaus, San Juan
            "Pacific SA Standard Time", // (UTC-04:00) Santiago
            "Newfoundland Standard Time", // (UTC-03:30) Newfoundland
            "Tocantins Standard Time", // (UTC-03:00) Araguaina
            "E. South America Standard Time", // (UTC-03:00) Brasilia
            "SA Eastern Standard Time", // (UTC-03:00) Cayenne, Fortaleza
            "Argentina Standard Time", // (UTC-03:00) City of Buenos Aires
            "Greenland Standard Time", // (UTC-03:00) Greenland
            "Montevideo Standard Time", // (UTC-03:00) Montevideo
            "Magallanes Standard Time", // (UTC-03:00) Punta Arenas
            "Saint Pierre Standard Time", // (UTC-03:00) Saint Pierre and Miquelon
            "Bahia Standard Time", // (UTC-03:00) Salvador
            "UTC-02", // (UTC-02:00) Coordinated Universal Time-02
            "Azores Standard Time", // (UTC-01:00) Azores
            "Cape Verde Standard Time", // (UTC-01:00) Cabo Verde Is.
            "UTC", // (UTC) Coordinated Universal Time
            "GMT Standard Time", // (UTC+00:00) Dublin, Edinburgh, Lisbon, London
            "Greenwich Standard Time", // (UTC+00:00) Monrovia, Reykjavik
            "Sao Tome Standard Time", // (UTC+00:00) Sao Tome
            "Morocco Standard Time", // (UTC+01:00) Casablanca
            "W. Europe Standard Time", // (UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna
            "Central Europe Standard Time", // (UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague
            "Romance Standard Time", // (UTC+01:00) Brussels, Copenhagen, Madrid, Paris
            "Central European Standard Time", // (UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb
            "W. Central Africa Standard Time", // (UTC+01:00) West Central Africa
            "GTB Standard Time", // (UTC+02:00) Athens, Bucharest
            "Middle East Standard Time", // (UTC+02:00) Beirut
            "Egypt Standard Time", // (UTC+02:00) Cairo
            "E. Europe Standard Time", // (UTC+02:00) Chisinau
            "Syria Standard Time", // (UTC+02:00) Damascus
            "West Bank Standard Time", // (UTC+02:00) Gaza, Hebron
            "South Africa Standard Time", // (UTC+02:00) Harare, Pretoria
            "FLE Standard Time", // (UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius
            "Israel Standard Time", // (UTC+02:00) Jerusalem
            "South Sudan Standard Time", // (UTC+02:00) Juba
            "Kaliningrad Standard Time", // (UTC+02:00) Kaliningrad
            "Sudan Standard Time", // (UTC+02:00) Khartoum
            "Libya Standard Time", // (UTC+02:00) Tripoli
            "Namibia Standard Time", // (UTC+02:00) Windhoek
            "Jordan Standard Time", // (UTC+03:00) Amman
            "Arabic Standard Time", // (UTC+03:00) Baghdad
            "Turkey Standard Time", // (UTC+03:00) Istanbul
            "Arab Standard Time", // (UTC+03:00) Kuwait, Riyadh
            "Belarus Standard Time", // (UTC+03:00) Minsk
            "Russian Standard Time", // (UTC+03:00) Moscow, St. Petersburg
            "E. Africa Standard Time", // (UTC+03:00) Nairobi
            "Volgograd Standard Time", // (UTC+03:00) Volgograd
            "Iran Standard Time", // (UTC+03:30) Tehran
            "Arabian Standard Time", // (UTC+04:00) Abu Dhabi, Muscat
            "Astrakhan Standard Time", // (UTC+04:00) Astrakhan, Ulyanovsk
            "Azerbaijan Standard Time", // (UTC+04:00) Baku
            "Russia Time Zone 3", // (UTC+04:00) Izhevsk, Samara
            "Mauritius Standard Time", // (UTC+04:00) Port Louis
            "Saratov Standard Time", // (UTC+04:00) Saratov
            "Georgian Standard Time", // (UTC+04:00) Tbilisi
            "Caucasus Standard Time", // (UTC+04:00) Yerevan
            "Afghanistan Standard Time", // (UTC+04:30) Kabul
            "West Asia Standard Time", // (UTC+05:00) Ashgabat, Tashkent
            "Ekaterinburg Standard Time", // (UTC+05:00) Ekaterinburg
            "Pakistan Standard Time", // (UTC+05:00) Islamabad, Karachi
            "Qyzylorda Standard Time", // (UTC+05:00) Qyzylorda
            "India Standard Time", // (UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi
            "Sri Lanka Standard Time", // (UTC+05:30) Sri Jayawardenepura
            "Nepal Standard Time", // (UTC+05:45) Kathmandu
            "Central Asia Standard Time", // (UTC+06:00) Astana
            "Bangladesh Standard Time", // (UTC+06:00) Dhaka
            "Omsk Standard Time", // (UTC+06:00) Omsk
            "Myanmar Standard Time", // (UTC+06:30) Yangon (Rangoon)
            "SE Asia Standard Time", // (UTC+07:00) Bangkok, Hanoi, Jakarta
            "Altai Standard Time", // (UTC+07:00) Barnaul, Gorno-Altaysk
            "W. Mongolia Standard Time", // (UTC+07:00) Hovd
            "North Asia Standard Time", // (UTC+07:00) Krasnoyarsk
            "N. Central Asia Standard Time", // (UTC+07:00) Novosibirsk
            "Tomsk Standard Time", // (UTC+07:00) Tomsk
            "China Standard Time", // (UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi
            "North Asia East Standard Time", // (UTC+08:00) Irkutsk
            "Singapore Standard Time", // (UTC+08:00) Kuala Lumpur, Singapore
            "W. Australia Standard Time", // (UTC+08:00) Perth
            "Taipei Standard Time", // (UTC+08:00) Taipei
            "Ulaanbaatar Standard Time", // (UTC+08:00) Ulaanbaatar
            "Aus Central W. Standard Time", // (UTC+08:45) Eucla
            "Transbaikal Standard Time", // (UTC+09:00) Chita
            "Tokyo Standard Time", // (UTC+09:00) Osaka, Sapporo, Tokyo
            "North Korea Standard Time", // (UTC+09:00) Pyongyang
            "Korea Standard Time", // (UTC+09:00) Seoul
            "Yakutsk Standard Time", // (UTC+09:00) Yakutsk
            "Cen. Australia Standard Time", // (UTC+09:30) Adelaide
            "AUS Central Standard Time", // (UTC+09:30) Darwin
            "E. Australia Standard Time", // (UTC+10:00) Brisbane
            "AUS Eastern Standard Time", // (UTC+10:00) Canberra, Melbourne, Sydney
            "West Pacific Standard Time", // (UTC+10:00) Guam, Port Moresby
            "Tasmania Standard Time", // (UTC+10:00) Hobart
            "Vladivostok Standard Time", // (UTC+10:00) Vladivostok
            "Lord Howe Standard Time", // (UTC+10:30) Lord Howe Island
            "Bougainville Standard Time", // (UTC+11:00) Bougainville Island
            "Russia Time Zone 10", // (UTC+11:00) Chokurdakh
            "Magadan Standard Time", // (UTC+11:00) Magadan
            "Norfolk Standard Time", // (UTC+11:00) Norfolk Island
            "Sakhalin Standard Time", // (UTC+11:00) Sakhalin
            "Central Pacific Standard Time", // (UTC+11:00) Solomon Is., New Caledonia
            "Russia Time Zone 11", // (UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky
            "New Zealand Standard Time", // (UTC+12:00) Auckland, Wellington
            "UTC+12", // (UTC+12:00) Coordinated Universal Time+12
            "Fiji Standard Time", // (UTC+12:00) Fiji
            "Chatham Islands Standard Time", // (UTC+12:45) Chatham Islands
            "UTC+13", // (UTC+13:00) Coordinated Universal Time+13
            "Tonga Standard Time", // (UTC+13:00) Nuku'alofa
            "Samoa Standard Time", // (UTC+13:00) Samoa
            "Line Islands Standard Time", // (UTC+14:00) Kiritimati Island
        };

        internal static string GetTimeZone(int index)
        {
            return Timezones[index];
        }
    }
}
