/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferNativeTokenRequestInputV3 = {
  receiverEntityId?: string;
  receiverWalletAddress?: string;
  amountToTransfer: string;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  operationId?: string | null;
};