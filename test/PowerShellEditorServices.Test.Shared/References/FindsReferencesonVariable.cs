// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.PowerShell.EditorServices.Services.TextDocument;

namespace Microsoft.PowerShell.EditorServices.Test.Shared.References;

public static class FindsReferencesOnVariableData
{
    public static readonly ScriptRegion SourceDetails = new(
        file: TestUtilities.NormalizePath("References/SimpleFile.ps1"),
        text: string.Empty,
        startLineNumber: 10,
        startColumnNumber: 17,
        startOffset: 0,
        endLineNumber: 0,
        endColumnNumber: 0,
        endOffset: 0);
}
