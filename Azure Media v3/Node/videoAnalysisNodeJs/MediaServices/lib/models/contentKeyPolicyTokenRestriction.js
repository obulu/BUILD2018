/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 */

'use strict';

const models = require('./index');

/**
 * Represents a token restriction. Provided token must match these requirements
 * for successful license or key delivery.
 *
 * @extends models['ContentKeyPolicyRestriction']
 */
class ContentKeyPolicyTokenRestriction extends models['ContentKeyPolicyRestriction'] {
  /**
   * Create a ContentKeyPolicyTokenRestriction.
   * @member {string} issuer The token issuer.
   * @member {string} audience The audience for the token.
   * @member {object} primaryVerificationKey The primary verification key.
   * @member {string} [primaryVerificationKey.odatatype] Polymorphic
   * Discriminator
   * @member {array} [alternateVerificationKeys] A list of alternative
   * verification keys.
   * @member {array} [requiredClaims] A list of required token claims.
   * @member {string} restrictionTokenType The type of token. Possible values
   * include: 'Unknown', 'Swt', 'Jwt'
   * @member {string} [openIdConnectDiscoveryDocument] The OpenID connect
   * discovery document.
   */
  constructor() {
    super();
  }

  /**
   * Defines the metadata of ContentKeyPolicyTokenRestriction
   *
   * @returns {object} metadata of ContentKeyPolicyTokenRestriction
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: '#Microsoft.Media.ContentKeyPolicyTokenRestriction',
      type: {
        name: 'Composite',
        polymorphicDiscriminator: {
          serializedName: '@odata.type',
          clientName: 'odatatype'
        },
        uberParent: 'ContentKeyPolicyRestriction',
        className: 'ContentKeyPolicyTokenRestriction',
        modelProperties: {
          odatatype: {
            required: true,
            serializedName: '@odata\\.type',
            isPolymorphicDiscriminator: true,
            type: {
              name: 'String'
            }
          },
          issuer: {
            required: true,
            serializedName: 'issuer',
            type: {
              name: 'String'
            }
          },
          audience: {
            required: true,
            serializedName: 'audience',
            type: {
              name: 'String'
            }
          },
          primaryVerificationKey: {
            required: true,
            serializedName: 'primaryVerificationKey',
            type: {
              name: 'Composite',
              polymorphicDiscriminator: {
                serializedName: '@odata.type',
                clientName: 'odatatype'
              },
              uberParent: 'ContentKeyPolicyRestrictionTokenKey',
              className: 'ContentKeyPolicyRestrictionTokenKey'
            }
          },
          alternateVerificationKeys: {
            required: false,
            serializedName: 'alternateVerificationKeys',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'ContentKeyPolicyRestrictionTokenKeyElementType',
                  type: {
                    name: 'Composite',
                    polymorphicDiscriminator: {
                      serializedName: '@odata.type',
                      clientName: 'odatatype'
                    },
                    uberParent: 'ContentKeyPolicyRestrictionTokenKey',
                    className: 'ContentKeyPolicyRestrictionTokenKey'
                  }
              }
            }
          },
          requiredClaims: {
            required: false,
            serializedName: 'requiredClaims',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'ContentKeyPolicyTokenClaimElementType',
                  type: {
                    name: 'Composite',
                    className: 'ContentKeyPolicyTokenClaim'
                  }
              }
            }
          },
          restrictionTokenType: {
            required: true,
            serializedName: 'restrictionTokenType',
            type: {
              name: 'String'
            }
          },
          openIdConnectDiscoveryDocument: {
            required: false,
            serializedName: 'openIdConnectDiscoveryDocument',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = ContentKeyPolicyTokenRestriction;