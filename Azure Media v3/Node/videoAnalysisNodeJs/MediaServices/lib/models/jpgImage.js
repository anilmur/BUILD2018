/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 */

'use strict';

const models = require('./index');

/**
 * Describes the properties for producing a series of JPEG images from the
 * input video.
 *
 * @extends models['Image']
 */
class JpgImage extends models['Image'] {
  /**
   * Create a JpgImage.
   * @member {array} [layers] Describes a collection of output JPEG layers to
   * be produced by the encoder.
   */
  constructor() {
    super();
  }

  /**
   * Defines the metadata of JpgImage
   *
   * @returns {object} metadata of JpgImage
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: '#Microsoft.Media.JpgImage',
      type: {
        name: 'Composite',
        polymorphicDiscriminator: {
          serializedName: '@odata.type',
          clientName: 'odatatype'
        },
        uberParent: 'Codec',
        className: 'JpgImage',
        modelProperties: {
          label: {
            required: false,
            serializedName: 'label',
            type: {
              name: 'String'
            }
          },
          odatatype: {
            required: true,
            serializedName: '@odata\\.type',
            isPolymorphicDiscriminator: true,
            type: {
              name: 'String'
            }
          },
          keyFrameInterval: {
            required: false,
            serializedName: 'keyFrameInterval',
            type: {
              name: 'TimeSpan'
            }
          },
          stretchMode: {
            required: false,
            serializedName: 'stretchMode',
            type: {
              name: 'String'
            }
          },
          start: {
            required: false,
            serializedName: 'start',
            type: {
              name: 'String'
            }
          },
          step: {
            required: false,
            serializedName: 'step',
            type: {
              name: 'String'
            }
          },
          range: {
            required: false,
            serializedName: 'range',
            type: {
              name: 'String'
            }
          },
          layers: {
            required: false,
            serializedName: 'layers',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'JpgLayerElementType',
                  type: {
                    name: 'Composite',
                    polymorphicDiscriminator: {
                      serializedName: '@odata.type',
                      clientName: 'odatatype'
                    },
                    uberParent: 'Layer',
                    className: 'JpgLayer'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = JpgImage;
