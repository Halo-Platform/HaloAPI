using Halo.Lux.Cryptography;
using System;
using System.Security.Cryptography;

namespace Halo.Lux.Wallet
{
    class WalletUtils
    {
        private static WalletUtils _instance = null;

        public static WalletUtils GetInstance()
        {
            if (_instance == null) _instance = new WalletUtils();
            return _instance;
        }

        /*public Object CreateAccount()
        {
            byte[] privateKey = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(privateKey);
            }
            return CreateAccount(privateKey);
        }

        public Object CreateAccount(byte[] keys)
        {
            KeyPair key = new KeyPair(keys);
        }*/
    }
}
