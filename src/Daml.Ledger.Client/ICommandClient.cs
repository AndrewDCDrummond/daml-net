﻿// Copyright(c) 2019 Digital Asset(Switzerland) GmbH and/or its affiliates.All rights reserved.
// SPDX-License-Identifier: Apache-2.0

namespace Daml.Ledger.Client
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Com.DigitalAsset.Ledger.Api.V1;

    public interface ICommandClient
    {
        void SubmitAndWait(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        Task SubmitAndWaitAsync(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        void SubmitAndWait(Commands commands);

        Task SubmitAndWaitAsync(Commands commands);

        Transaction SubmitAndWaitForTransaction(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        string SubmitAndWaitForTransactionId(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        TransactionTree SubmitAndWaitForTransactionTree(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        Task<Transaction> SubmitAndWaitForTransactionAsync(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        Task<string> SubmitAndWaitForTransactionIdAsync(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);

        Task<TransactionTree> SubmitAndWaitForTransactionTreeAsync(
            string ledgerId,
            string applicationId,
            string workflowId,
            string commandId,
            string party,
            DateTime ledgerEffectiveTime,
            DateTime maximumRecordTime,
            IEnumerable<Command> commands);
    }
}