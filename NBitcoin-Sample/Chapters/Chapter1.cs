using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace NBitcoin_Sample.Chapters
{
    class Chapter1
    {

        public void Lesson1()
        {
            Key key = new Key(); //generates a new private key.     
            PubKey pubKey = key.PubKey; //gets the matching public key.     
            Console.WriteLine("Public Key: {0}", pubKey);
            KeyId hash = pubKey.Hash; //gets a hash of the public key.     
            Console.WriteLine("Hashed public key: {0}", hash);
            BitcoinAddress address = pubKey.GetAddress(Network.Main); //retrieves the bitcoin address.     
            Console.WriteLine("Address: {0}", address);
            Script scriptPubKeyFromAddress = address.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from address: {0}", scriptPubKeyFromAddress);
            Script scriptPubKeyFromHash = hash.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from hash: {0}", scriptPubKeyFromHash);

        }

        public void Lesson2()
        {
            Script scriptPubKey = new Script("OP_DUP OP_HASH160 1b2da6ee52ac5cd5e96d2964f12a0241851f8d2a OP_EQUALVERIFY OP_CHECKSIG");
            BitcoinAddress address = scriptPubKey.GetDestinationAddress(Network.Main);
            Console.WriteLine("Bitcoin Address: {0}", address);
        }
    }
}
