﻿ciphertext = ciphertext.ToUpper();

char[] alfabeti = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
                                        'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};


char[] mesazhiEch = ciphertext.ToCharArray();
string[] tekstiKontrollues = new string[] { "EDHE", "ESHTE" };

string[] Split_Mesazhi = ciphertext.Split(' ');
