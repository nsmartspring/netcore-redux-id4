const requestProductType = 'REQUEST_PRODUCTIES';
const receiveProductType = 'RECEIVE_PRODUCTIES';
const initialState = { producties: [], isLoading: false };

export const actionCreators = {
    requestProducties: page => async (dispatch, getState) => {
        if (page === getState().producties.page) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestProductType, page });

        const url = `api/Product/find?page=${page}`;
        const response = await fetch(url);
        const data = await response.json();
        const producties = data.items;
        dispatch({ type: receiveProductType, page, producties });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestProductType) {
        return {
            ...state,
            page: action.page,
            isLoading: true
        };
    }

    if (action.type === receiveProductType) {
        return {
            ...state,
            page: action.page,
            producties: action.producties,
            isLoading: false
        };
    }

    return state;
};
