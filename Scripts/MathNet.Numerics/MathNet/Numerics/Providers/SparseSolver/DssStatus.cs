namespace MathNet.Numerics.Providers.SparseSolver
{
	public enum DssStatus
	{
		MKL_DSS_SUCCESS = 0,
		MKL_DSS_ZERO_PIVOT = -1,
		MKL_DSS_OUT_OF_MEMORY = -2,
		MKL_DSS_FAILURE = -3,
		MKL_DSS_ROW_ERR = -4,
		MKL_DSS_COL_ERR = -5,
		MKL_DSS_TOO_FEW_VALUES = -6,
		MKL_DSS_TOO_MANY_VALUES = -7,
		MKL_DSS_NOT_SQUARE = -8,
		MKL_DSS_STATE_ERR = -9,
		MKL_DSS_INVALID_OPTION = -10,
		MKL_DSS_OPTION_CONFLICT = -11,
		MKL_DSS_MSG_LVL_ERR = -12,
		MKL_DSS_TERM_LVL_ERR = -13,
		MKL_DSS_STRUCTURE_ERR = -14,
		MKL_DSS_REORDER_ERR = -15,
		MKL_DSS_VALUES_ERR = -16,
		MKL_DSS_STATISTICS_INVALID_MATRIX = -17,
		MKL_DSS_STATISTICS_INVALID_STATE = -18,
		MKL_DSS_STATISTICS_INVALID_STRING = -19,
		MKL_DSS_REORDER1_ERR = -20,
		MKL_DSS_PREORDER_ERR = -21,
		MKL_DSS_DIAG_ERR = -22,
		MKL_DSS_I32BIT_ERR = -23,
		MKL_DSS_OOC_MEM_ERR = -24,
		MKL_DSS_OOC_OC_ERR = -25,
		MKL_DSS_OOC_RW_ERR = -26
	}
}