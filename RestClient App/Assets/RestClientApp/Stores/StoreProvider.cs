using RestClientApp.Models;
using Unity.UIWidgets;
using Unity.UIWidgets.Redux;

namespace RestClientApp.Stores {
    public static class StoreProvider {
        static Store<AppState> _store;

        public static Store<AppState> store {
            get {
                if (_store != null) {
                    return _store;
                }

                var middleware = new[] {
//                    ReduxLogging.create<AppState>(),
                    ReduxThunk.create<AppState>()
                };
                _store = new Store<AppState>(
                    AppReducer.Reduce,
                    AppState.initialState(),
                    middleware
                );
                return _store;
            }
        }
    }
}