/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetUserCurrenciesResponse = {
  data: Array<{
    address: string;
    name: string;
    symbol: string;
    decimals: number;
    logoUri?: string;
    chainId: number;
    balance: string;
  }>;
};
