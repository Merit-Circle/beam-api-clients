/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetTransactionsResponse = {
  data: Array<{
    id: string;
    createdAt: string;
    updatedAt: string;
    chainId: number;
    intent: {
      interactions?: Array<{
        to?: string;
        value?: string;
        contract?: string;
        functionName?: string;
        functionArgs?: any[];
      }> | null;
      message?: string | null;
    };
    /**
     * The transaction object exists if you created the transaction deterministically and contains information about the on-chain transaction
     */
    transaction?: {
      createdAt: string;
      blockNumber?: number;
      hash?: string;
      gasUsed?: string;
      gasFee?: string;
      status?: number;
      logs?: Array<{
        blockNumber: number;
        blockHash: string;
        transactionIndex: number;
        removed: boolean;
        address: string;
        data: string;
        topics: string[];
        transactionHash: string;
        logIndex: number;
        orphaned?: boolean | null;
      }>;
    } | null;
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
