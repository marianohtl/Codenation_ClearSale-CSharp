using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        public string Crypt(string message)
        {
            if(message == null)
            {
                throw new ArgumentNullException("Valores nulos não são aceitos.");
            }

            String messageReceived , encryptedMessage = "";
            String alfabeto = "abcdefghijklmnopqrstuvwxyz";
            String naoCifrados = "1234567890 ";
            messageReceived = message.ToLower();
            

            int chave = 3;
            int indice;

            foreach (char letraMsg in messageReceived)
            { 
                if (alfabeto.Contains(letraMsg.ToString()))
                {
                    indice = alfabeto.IndexOf(letraMsg);
                    indice+= chave;
                    
                    if(indice >= 0 && indice <= 25)
                    {
                        encryptedMessage += alfabeto[indice];   
                    }
                    else
                    {
                        indice = 25 - indice;
                        indice = Math.Abs(indice);
                        indice = indice - 1;
                        encryptedMessage += alfabeto[indice];
                    }
                }
                else if(naoCifrados.Contains(letraMsg.ToString()))
                {
                    encryptedMessage += letraMsg;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Caracter inválido.");
                }


            }
            return encryptedMessage;
        }

        public string Decrypt(string cryptedMessage)
        {

            if (cryptedMessage == null)
            {
                throw new ArgumentNullException("Valores nulo não são aceitos.");
            }

            String messageReceived, decryptMessage = "";
            String alfabeto = "abcdefghijklmnopqrstuvwxyz";
            String naoCifrados = "1234567890 ";
            
            messageReceived = cryptedMessage.ToLower();

            int chave = 3;
            int indice;

          
            foreach (char letraMsg in messageReceived)
            {

                if (alfabeto.Contains(letraMsg.ToString()))
                {
                    indice = alfabeto.IndexOf(letraMsg);
                    indice -= chave;
                    if (indice >= 0 && indice <= 25)
                    {
                        decryptMessage += alfabeto[indice];
                    }
                    else
                    {
                        indice = 25 + indice;
                        indice = Math.Abs(indice);
                        indice = indice + 1;
                        decryptMessage += alfabeto[indice];
                    }
                }
                else if (naoCifrados.Contains(letraMsg.ToString()))
                {
                    decryptMessage += letraMsg;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Caracter inválido.");
                }


            }
            return decryptMessage;

        }
    }
}
