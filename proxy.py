from mitmproxy import http
from mitmproxy import ctx
from mitmproxy.proxy import layer, layers

LOGIN_PATHS = [
    "member/api/v1/game/auth/signin/refresh/token",
    "membeeQr/api/v1/game/auth/login/verify/token/refresh",
    "member/api/v1/game/auth/check/available",
    "member/api/v1/game/auth/signin",
    "oz/auth/access"
]

def load(loader):
    # ctx.options.web_open_browser = False
    ctx.options.connection_strategy = "lazy"
    ctx.options.upstream_cert = False
    ctx.options.ssl_insecure = True
    ctx.options.allow_hosts = ['hybegames.com', 'hybeim.com']
    
def request(flow: http.HTTPFlow) -> None:
    if "oz/game" in flow.request.url or '/'.join(flow.request.path_components) in LOGIN_PATHS:
        flow.request.host = "127.0.0.1"
        flow.request.port = 443
