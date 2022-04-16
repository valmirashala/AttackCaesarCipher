List<string> list = new List<string>();

for (int i = 0; i < Split_Mesazhi.Length; i++)
    for (int j = 0; j < tekstiKontrollues.Length; j++)
        if (Split_Mesazhi[i].Length == tekstiKontrollues[j].Length)
            list.Add(Split_Mesazhi[i]);
string[] vargu = list.ToArray();

int celesi = 0;
for (int i = 0; i < vargu.Length; i++)
{
    celesi = kontrollo(tekstiKontrollues, vargu[i]);
    if (celesi != -1)
    {
        sms += Mesazhi(ciphertext, celesi);
        MessageBox.Show("Teksti i dekripturar: " + sms);
        break;

    }
}
this.Close();
            