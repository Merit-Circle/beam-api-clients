/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAllProfilesResponse = {
  data: Array<{
    id: string;
    createdAt: any;
    updatedAt: any;
    externalId: string;
    externalEntityId: string;
    gameId: string;
    userId: string | null;
    userConnectionCreatedAt?: any;
    wallets: Array<{
      id: string;
      createdAt: any;
      updatedAt: any;
      externalId: string;
      address: string;
      chainId: number;
      profileId: string | null;
      userId: string | null;
    }>;
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
