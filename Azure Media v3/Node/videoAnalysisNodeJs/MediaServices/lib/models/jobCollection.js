/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 */

'use strict';

/**
 * A collection of Job items.
 */
class JobCollection extends Array {
  /**
   * Create a JobCollection.
   * @member {string} [odatanextLink] A link to the next page of the collection
   * (when the collection contains too many results to return in one response).
   */
  constructor() {
    super();
  }

  /**
   * Defines the metadata of JobCollection
   *
   * @returns {object} metadata of JobCollection
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'JobCollection',
      type: {
        name: 'Composite',
        className: 'JobCollection',
        modelProperties: {
          value: {
            required: false,
            serializedName: '',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'JobElementType',
                  type: {
                    name: 'Composite',
                    className: 'Job'
                  }
              }
            }
          },
          odatanextLink: {
            required: false,
            serializedName: '@odata\\.nextLink',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = JobCollection;
