﻿using System;

public static string Mesazhi(string tekstiKoduar, int celsi)
{
    StringBuilder tekstiDekoduar = new StringBuilder(tekstiKoduar);
    for (int i = 0; i < tekstiKoduar.Length; i++)
    {
        if (tekstiKoduar[i] != ' ')
            tekstiDekoduar[i] = ((char)((tekstiKoduar[i] - 'A' - celsi + 26) % 26 + 'A'));
    }
    return tekstiDekoduar.ToString();
}

