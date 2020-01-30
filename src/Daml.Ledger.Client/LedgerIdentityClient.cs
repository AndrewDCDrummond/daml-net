﻿// Copyright(c) 2019 Digital Asset(Switzerland) GmbH and/or its affiliates.All rights reserved.
// SPDX-License-Identifier: Apache-2.0

namespace Daml.Ledger.Client
{
    using System.Threading.Tasks;
    using Com.DigitalAsset.Ledger.Api.V1;
    using Grpc.Core;

    public class LedgerIdentityClient : ILedgerIdentityClient
    {
        private readonly LedgerIdentityService.LedgerIdentityServiceClient _ledgerIdentityClient;

        public LedgerIdentityClient(Channel channel)
        {
            _ledgerIdentityClient = new LedgerIdentityService.LedgerIdentityServiceClient(channel);
        }

        public string GetLedgerIdentity()
        {
            var response = _ledgerIdentityClient.GetLedgerIdentity(new GetLedgerIdentityRequest());
            return response.LedgerId;
        }

        public async Task<string> GetLedgerIdentityAsync()
        {
            var response = await _ledgerIdentityClient.GetLedgerIdentityAsync(new GetLedgerIdentityRequest());
            return response.LedgerId;
        }
    }
}
