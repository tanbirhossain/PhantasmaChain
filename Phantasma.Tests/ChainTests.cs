﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using Phantasma.Blockchain;
using Phantasma.Cryptography;
using Phantasma.VM.Utils;

namespace Phantasma.Tests
{
    [TestClass]
    public class ChainTests
    {
        [TestMethod]
        public void TestChain()
        {
            var owner = KeyPair.Generate();
            var nexus = new Nexus(owner);

            var miner = KeyPair.Generate();
            var third = KeyPair.Generate();

            var chain = nexus.RootChain;
            var token = nexus.NativeToken;

            var tx = new Transaction(ScriptUtils.TokenTransferScript(chain, token, owner.Address, third.Address, 5), 0, 0);
            tx.Sign(owner);

            /*var block = ProofOfWork.MineBlock(chain, miner.Address, new List<Transaction>() { tx });
            chain.AddBlock(block);*/
        }
    }
}