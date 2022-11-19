﻿namespace Fydar.Samples.Grammars;

public struct TokenKind
{
	public static readonly TokenKind Unknown;

	internal readonly ushort tokenId;

	public TokenKindName Name => TokenKindName.catalogue[tokenId];

	internal TokenKind(ushort tokenId)
	{
		this.tokenId = tokenId;
	}

	public bool IsKindOf(TokenKind tokenKind)
	{
		if (tokenId == tokenKind.tokenId)
		{
			return true;
		}

		var otherTokenSources = TokenKindName.catalogue[tokenKind.tokenId].AllInheritsFrom;

		foreach (var otherTokenSource in otherTokenSources)
		{
			if (tokenKind.tokenId == otherTokenSource.tokenId)
			{
				return true;
			}
		}
		return false;
	}

	public static bool operator ==(TokenKind left, TokenKind right)
	{
		return left.tokenId == right.tokenId;
	}

	public static bool operator !=(TokenKind left, TokenKind right)
	{
		return left.tokenId == right.tokenId;
	}

	public override string ToString()
	{
		return $"{Name}";
	}
}
