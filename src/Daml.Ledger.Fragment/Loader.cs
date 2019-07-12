﻿// Copyright(c) 2019 Digital Asset(Switzerland) GmbH and/or its affiliates.All rights reserved.
// SPDX-License-Identifier: Apache-2.0

namespace Daml.Ledger.Fragment
{
    using System;
    using System.IO;
    using Com.DigitalAsset.Daml_lf.DamlLf;
    using Com.DigitalAsset.Daml_lf.DamlLf1;

    public static class Loader
    {
        public static Package Load(string dalfFile)
        {
            using (var stream = new FileStream(dalfFile, FileMode.Open))
            {
                var archive = Archive.Parser.ParseFrom(stream);
                var payload = ArchivePayload.Parser.ParseFrom(archive.Payload);
                switch (payload.SumCase)
                {
                    case ArchivePayload.SumOneofCase.DamlLf1:
                        return payload.DamlLf1;
                    default:
                        throw new ApplicationException("Unsupported DAML-LF version");
                }
            }
        }
    }
}