﻿namespace Kong.Plugins.Model
{
    public class CorsPluginConfig
    {
        public bool Credentials { get; set; }

        public bool PreflightContinue { get; set; }

        public string Origin { get; set; }

        public object Methods { get; set; }

        public object Headers { get; set; }

        public object ExposedHeaders { get; set; }

        public long MaxAge { get; set; }
    }
}